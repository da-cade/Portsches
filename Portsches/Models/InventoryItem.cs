using System.Collections.Generic;

namespace Portsches.Models
{
	public class InventoryItem
	{
		public List<string> Categories { get; set; }
		public int Name { get; set; }
		public decimal PriceRetail { get; set; }
		public decimal PriceCurrent { get; set; }
		public int StoreLocation { get; set; }
		public bool InStock { get; set; }
		public int Quantity { get; set; }
		public string VendorID { get; set; }
		public string SKU { get; set; }
		public string Image { get; set; }
		public string Notes { get; set; }
		public List<string> Tags { get; set; }
	}
}