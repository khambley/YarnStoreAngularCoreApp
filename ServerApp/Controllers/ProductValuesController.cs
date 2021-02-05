using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ServerApp.Controllers
{
	// see https://localhost:5001/swagger/index.html to view entities in the browser

	[Route("api/products")]
	[ApiController]
	public class ProductValuesController : Controller
	{
		private DataContext _context;
		public ProductValuesController(DataContext context)
		{
			_context = context;
		}

		// GetProduct - get one product with Id, web service endpoint https://localhost:5001/api/products/1
		[HttpGet("{id}")]
		public Product GetProduct(long id)
		{
			// Add a delay to simulate async requests on a production server.
			//System.Threading.Thread.Sleep(5000);
			
			Product result = _context.Products
				.Include(p => p.Supplier).ThenInclude(s => s.Products) //If you want all the products under a certain Supplier...
				.Include(p => p.Ratings)
				.Include(p => p.ImageFiles)
				.FirstOrDefault(p => p.ProductId == id);

			// Solves circular reference, JSON serialization error when including nav properties.
			if(result != null)
			{
				if(result.Supplier != null)
				{
					// result.Supplier.Products = null; 
					// Instead of setting Supplier.Products to null, new product objects w/o circular ref to the Supplier
					// are created using LINQ Select method
					result.Supplier.Products = result.Supplier.Products.Select(p =>
						new Product
						{
							ProductId = p.ProductId,
							Name = p.Name,
							Category = p.Category,
							Description = p.Description,
							Price = p.Price,
						});

				}
				if(result.Ratings != null)
				{
					foreach(Rating r in result.Ratings)
					{
						r.Product = null;
					}
				}
				if(result.ImageFiles != null)
				{
					foreach(ImageFileName fn in result.ImageFiles)
					{
						fn.Product = null;
					}
				}
			}
			return result;
		} // end GetProduct

		// GetProducts - get multiple products list, web service endpoint https://localhost:5001/api/products?related=true
		[HttpGet]
		public IEnumerable<Product> GetProducts(bool related = false)
		{
			IQueryable<Product> query = _context.Products;
			if (related)
			{
				query = query.Include(p => p.Supplier).Include(p => p.Ratings);
				List<Product> data = query.ToList();
				data.ForEach(p =>
				{
					if (p.Supplier != null)
					{
						p.Supplier.Products = null;
					}
					if (p.Ratings != null)
					{
						p.Ratings.ForEach(r => r.Product = null);
					}
					if(p.ImageFiles != null)
					{
						p.ImageFiles.ForEach(fn => fn.Product = null);
					}
				});
				return data;
			}
			else
			{
				return query; 
			}
		} // end GetProducts
	}
}
