using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerApp.Models;
using Microsoft.EntityFrameworkCore;

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

		//web service endpoint https://localhost:5001/api/products/1
		[HttpGet("{id}")]
		public Product GetProduct(long id)
		{
			// Add a delay to simulate async requests on a production server.
			//System.Threading.Thread.Sleep(5000);
			// This is to smoke test the web service endpoint. You should see JSON data in the web browser.
			return _context.Products
				.Include(p => p.Supplier)
				.Include(p => p.Ratings)
				.Include(p => p.ImageFiles)
				.FirstOrDefault(p => p.ProductId == id);


		}
	}
}
