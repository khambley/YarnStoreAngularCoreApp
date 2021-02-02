using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Models
{
	public class Needles : Product
	{
		public double Length { get; set; }
		public int SizeUS { get; set; }
		public string NeedlesType { get; set; } // straight, double point, circular
		public bool IsInterchangeable { get; set; } // if false, (default) then it is Fixed

	}
}
