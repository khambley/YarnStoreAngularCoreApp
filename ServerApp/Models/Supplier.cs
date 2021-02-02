using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Models
{
	public class Supplier
	{
		public long SupplierId { get; set; }
		public string Name { get; set; }
		public string? StreetAddress { get; set; }
		public string? MailingAddress { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string? ZipCode { get; set; }
		public string? Phone { get; set; }
		public string? WebsiteUrl { get; set; }
		public string? Email { get; set; }

		public IEnumerable<Product> Products { get; set; }

	}
}
