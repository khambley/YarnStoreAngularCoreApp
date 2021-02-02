using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Models
{
	public class Product
	{
		public long ProductId { get; set; }
		public string Name { get; set; }
		public string Category { get; set; }
		public string Description { get; set; }

		[Column(TypeName="decimal(8,2)")]
		public decimal Price { get; set; }
		public int QuantityOnHand { get; set; }
		public string? Manufacturer { get; set; }

		public Supplier Supplier { get; set; }
		public List<Rating> Ratings { get; set; }

		[NotMapped]
		public IFormFile ImageFile { get; set; }
		public List<ImageFileName> ImageFiles { get; set; }

	}
}
