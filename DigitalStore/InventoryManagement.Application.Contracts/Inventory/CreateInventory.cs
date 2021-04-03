using ShopManagement.Application.Contracts.Product;
using System.Collections.Generic;


namespace InventoryManagement.Application.Contracts.Inventory
{
    public class CreateInventory
    {
        public long ProductId { get; set; }
        public double UnitPrice { get; set; }
        public string Description { get; set; }
        public List<ProductViewModel> Products { get; set; }
    }
}
