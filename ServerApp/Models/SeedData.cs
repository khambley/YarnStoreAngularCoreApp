using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Models
{
	public class SeedData
	{
		public static void SeedDatabase(DataContext context)
		{
			context.Database.Migrate();
			if (context.Products.Count() == 0)
			{
				var s1 = new Supplier
				{
					Name = "Darn Good Yarn",
					City = "Clifton Park",
					State = "NY",
					WebsiteUrl = "https://www.darngoodyarn.com/"
				};
				var s2 = new Supplier
				{
					Name = "Fiber Seed",
					MailingAddress = "PO Box 3",
					City = "Blanchester",
					State = "OH",
					ZipCode = "45107",
					Phone = "937-625-1242",
					WebsiteUrl = "https://www.thefiberseed.com/"
				};
				var s3 = new Supplier
				{
					Name = "Jimmy Beans",
					City = "Reno",
					State = "NV",
					WebsiteUrl = "https://www.jimmybeanswool.com/"
				};
				var s4 = new Supplier
				{
					Name = "Knotty Lady Yarns, LLC",
					StreetAddress = "632 SE Jackson Street",
					City = "Roseburg",
					State = "OR",
					ZipCode = "97470",
					Phone = "541-673-2199",
					WebsiteUrl = "https://www.knottyladyyarns.com/"
				};
				var s5 = new Supplier
				{
					Name = "2 Needle Chicks",
					StreetAddress = "406 Peterson Road",
					City = "Libertyville",
					State = "IL",
					ZipCode = "60048",
					Phone = "847-549-3611",
					WebsiteUrl = "https://www.2needlechicks.com/"
				};
				var s6 = new Supplier
				{
					Name = "D Marie Knit and Fiber",
					StreetAddress = "422 Water Street",
					City = "Prairie du Sac",
					State = "WI",
					ZipCode = "53578",
					Phone = "608-370-2414",
					WebsiteUrl = "https://www.dmarieknitandfiber.com/",
					Email = "dmarieknitandfiber@yahoo.com"
				};

				context.Products.AddRange(
				// Product #1
				new Yarn
				{
					Name = "Archipelago Sprout Worsted Superwash",
					Category = "Yarn",
					Description = "Archipelago swirled with Night Zone and Wenge on a Clearwater background.",
					YarnType = "Worsted",
					Weight = 136,
					Yardage = 250.0,
					FiberBlend = "90% Merino Wool with Nylon",
					MainColor = "Blue-Green",
					KnittingGauge = "4.5-5 sts = 1\" in US 7-8",
					CrochetGauge = "3.5 sc = 1\" on a I / 5.5 mm",
					IsWashable = true,
					Collection = "Kaleidoscope",
					Price = 26,
					QuantityOnHand = 1,
					Manufacturer = "Fiber Seed",
					Supplier = s2,
					ImageFiles = new List<ImageFileName> { 
						new ImageFileName { FileName = "FiberSeed_Sprout_Worsted_Archipelago1.jpeg"}},
					Ratings = new List<Rating> {
						new Rating { Stars = 4 }}
				},
				// Product #2
				new Yarn
				{
					Name = "Dirty Seahorse Sprout Worsted Superwash",
					Category = "Yarn",
					Description = "Dirty Seahorse\" is a Kaleidoscope swirled with teal and brown on a natural background.",
					YarnType = "Worsted",
					Weight = 136,
					Yardage = 250.0,
					FiberBlend = "90% Merino Wool with Nylon",
					MainColor = "Teal Brown",
					KnittingGauge = "4.5-5 sts = 1\" in US 7-8",
					CrochetGauge = "3.5 sc = 1\" on a I / 5.5 mm",
					IsWashable = true,
					Collection = "Kaleidoscope",
					Price = 26,
					QuantityOnHand = 1,
					Manufacturer = "Fiber Seed",
					Supplier = s2,
					ImageFiles = new List<ImageFileName> {
						new ImageFileName { FileName = "FiberSeed_Sprout_Worsted_Dirty_Seahorse1.jpeg"}},
					Ratings = new List<Rating> {
						new Rating { Stars = 4 }, new Rating { Stars = 3 }}
				},
				// Product #3
				new Yarn
				{
					Name = "Dirty Seahorse Sprout DK Superwash",
					Category = "Yarn",
					Description = "Dirty Seahorse\" is a Kaleidoscope swirled with teal and brown on a natural background.",
					YarnType = "DK",
					Weight = 100,
					Yardage = 250.0,
					FiberBlend = "90% Merino Wool with Nylon",
					MainColor = "Teal Brown",
					KnittingGauge = "4.5-5 sts = 1\" in US 7-8",
					CrochetGauge = "3.5 sc = 1\" on a I / 5.5 mm",
					IsWashable = true,
					Collection = "Kaleidoscope",
					Price = 22,
					QuantityOnHand = 1,
					Manufacturer = "Fiber Seed",
					Supplier = s2,
					ImageFiles = new List<ImageFileName> {
						new ImageFileName { FileName = "FiberSeed_Sprout_DK_Dirty_Seahorse1.jpeg"}},
					Ratings = new List<Rating> {
					new Rating { Stars = 3 }}
				},
				// Product #4
				new Yarn
				{
					Name = "Baby Alpaca Brush",
					Category = "Yarn",
					Description = "Very soft and lightweight yarn.",
					YarnType = "Chunky",
					Weight = 50,
					Yardage = 110.0,
					FiberBlend = "80% Baby Alpaca, 20% Acrylic",
					MainColor = "Silver 6307",
					KnittingGauge = "3.5 sts = 1\" on US 9",
					CrochetGauge = "",
					IsWashable = false,
					Collection = "Alpaca Brand",
					Price = 9,
					QuantityOnHand = 4,
					Manufacturer = "Plymouth Yarn Company, Inc.",
					Supplier = s4,
					ImageFiles = new List<ImageFileName> {
						new ImageFileName { FileName = "Plymouth_Yarns_Baby_Alpaca_Brush1.jpg"}},
					Ratings = new List<Rating> {
						new Rating { Stars = 3 }}
				},
				// Product #5
				new Yarn
				{
					Name = "Baby Alpaca Brush",
					Category = "Yarn",
					Description = "Very soft and lightweight yarn.",
					YarnType = "Chunky",
					Weight = 50,
					Yardage = 110.0,
					FiberBlend = "80% Baby Alpaca, 20% Acrylic",
					MainColor = "Garnet 1001",
					KnittingGauge = "3.5 sts = 1\" on US 9",
					CrochetGauge = "",
					IsWashable = false,
					Collection = "Alpaca Brand",
					Price = 9,
					QuantityOnHand = 2,
					Manufacturer = "Plymouth Yarn Company, Inc.",
					Supplier = s4,
					ImageFiles = new List<ImageFileName> {
						new ImageFileName { FileName = "Plymouth_Yarns_Baby_Alpaca_Brush1.jpg"}},
					Ratings = new List<Rating> {
						new Rating { Stars = 3 }}
				},
				// Product #6
				new Yarn
				{
					Name = "Baby Alpaca Brush",
					Category = "Yarn",
					Description = "Very soft and lightweight yarn.",
					YarnType = "Chunky",
					Weight = 50,
					Yardage = 110.0,
					FiberBlend = "80% Baby Alpaca, 20% Acrylic",
					MainColor = "Teal Green 0017",
					KnittingGauge = "3.5 sts = 1\" on US 9",
					CrochetGauge = "",
					IsWashable = false,
					Collection = "Alpaca Brand",
					Price = 11,
					QuantityOnHand = 2,
					Manufacturer = "Plymouth Yarn Company, Inc.",
					Supplier = s5,
					ImageFiles = new List<ImageFileName> {
						new ImageFileName { FileName = "Plymouth_Yarns_Baby_Alpaca_Brush1.jpg"}},
					Ratings = new List<Rating> {
						new Rating { Stars = 3 }}
				},
				// Product #7
				new Yarn
				{
					Name = "Deep End, Merino DK Superwash",
					Category = "Yarn",
					Description = "Smooth, soft, non-scratchy yarn with a tighter twist and round profile. Great all purpose workhorse yarn, next to the skin soft. Wonderful stitch definition. Hand-dyed in small batches in Cork, Ireland.",
					YarnType = "DK",
					Weight = 115,
					Yardage = 218.7,
					FiberBlend = "100% Merino Wool",
					MainColor = "Blue-Violet",
					KnittingGauge = "",
					CrochetGauge = "",
					IsWashable = true,
					Collection = "Merino DK",
					Price = 30,
					QuantityOnHand = 1,
					Manufacturer = "Hedgehog Fibres (HHF)",
					Supplier = s6,
					ImageFiles = new List<ImageFileName> {
						new ImageFileName { FileName = "HedgehogFibres_DeepEnd_MerinoDK.jpg"}},
					Ratings = new List<Rating> {
						new Rating { Stars = 3 }}
				},
				// Product #8
				new Yarn
				{
					Name = "Arroyo Superwash",
					Category = "Yarn",
					Description = "Smooth, soft, non-scratchy yarn with a tighter twist and round profile. Great all purpose workhorse yarn, next to the skin soft. Wonderful stitch definition. Hand-dyed in small batches in Cork, Ireland.",
					YarnType = "DK",
					Weight = 100,
					Yardage = 335.0,
					FiberBlend = "100% Merino Wool",
					MainColor = "Blue-Violet",
					KnittingGauge = "20-22 sts = 1\" on US 4-6 needles",
					CrochetGauge = "",
					IsWashable = true,
					Collection = "Arroyo",
					Price = 20,
					QuantityOnHand = 1,
					Manufacturer = "Malabrigo",
					Supplier = s6,
					ImageFiles = new List<ImageFileName> {
						new ImageFileName { FileName = "Malabrigo_Arroyo_164Sur_DK.jpg"}},
					Ratings = new List<Rating> {
						new Rating { Stars = 3 }}
				});
				context.SaveChanges();
			}	
		}
	}
}
