using IFSPstore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPstore.Domain.Entities
{
    public class Product : BaseEntitiy<int>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }
        public String SaleUnity { get; set; }
        public Category Category { get; set; }

        public Product(int id, string name, decimal price, decimal quantity, DateTime purchaseDate, string saleUnity, Category category) : base(id)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            PurchaseDate = purchaseDate;
            SaleUnity = saleUnity;
            Category = category;
        }

        public Product()
        {

        }
    }
}
