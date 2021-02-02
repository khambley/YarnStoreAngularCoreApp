using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Models
{
	public class ImageFileName
	{
		public long ImageFileNameId { get; set; }
		public string FileName { get; set; }
		public Product Product { get; set; }
	}
}
