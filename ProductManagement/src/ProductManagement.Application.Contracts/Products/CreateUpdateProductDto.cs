using System;

namespace ProductManagement.Products
{
    public class CreateUpdateProductDto
    {
        public Guid CategoryId { get; set; }
        public string? Name { get; set; }
        public float Price { get; set; }

        public bool IsFreeCargo { get; set; }

        public DateTime ReleaseDate { get; set;  }

        public ProductStockState StockState { get; set; }

        
    }
}