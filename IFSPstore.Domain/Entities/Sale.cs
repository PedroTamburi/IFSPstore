using IFSPstore.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IFSPstore.Domain.Entities.Sale;

namespace IFSPstore.Domain.Entities
{
    public class Sale : BaseEntitiy<int>
    {
        public DateTime SaleDate { get; set; }
        public float TotalValue { get; set; }
        public User SalesMan { get; set; }
        public Customer Customer { get; set; }
        public List<SaleItem> SaleItems { get; set; }

        public Sale(int id, DateTime saleDate, float totalValue, User salesMan, Customer customer) : base(id)
        {
            SaleDate = saleDate;
            TotalValue = totalValue;
            SalesMan = salesMan;
            Customer = customer;
            SaleItems = new List<SaleItem>();
        }

      
        public Sale()
        {

        }
    }
    public class SaleItem : BaseEntitiy<int>
    {
        public Sale Sale { get; set; }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public SaleItem(int id, Sale sale, Product product, decimal quantity, decimal unitPrice, decimal totalPrice)
        {
            Sale = sale;
            Product = product;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = totalPrice;
        }
        public SaleItem()
        {
            
        }
    }
}
