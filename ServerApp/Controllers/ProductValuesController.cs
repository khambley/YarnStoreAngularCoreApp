using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerApp.Models;

namespace ServerApp.Controllers
{
	
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
			// This is to smoke test the web service endpoint
			return _context.Products.Find(id);
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}
