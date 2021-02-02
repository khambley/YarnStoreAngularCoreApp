using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Models
{
	public class Yarn : Product
	{
		public string? YarnType { get; set; }
		public double Weight { get; set; } // in grams
		public double Yardage { get; set; }
		public string? FiberBlend { get; set; }
		public string? MainColor { get; set; }
		public string? KnittingGauge { get; set; }
		public string? CrochetGauge { get; set; }
		public bool IsWashable { get; set; }
		public string? Collection { get; set; }
	}
}
