using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities;

public class Sale : BaseEntity<int>
{
    public DateTime Date { get; set; }
    public decimal TotalValue { get; set; }
    public User Salesman { get; set; }
    public Customer Customer { get; set; }
    public List<SaleItem> Items { get; set; } = [];

    public Sale()
    {
        
    }

    public Sale(int id, DateTime date, decimal totalValue, List<SaleItem> items, User user, Customer customer)
        : base(id)
    {
        Date = date;
        TotalValue = totalValue;
        Items = items;
        Salesman = user;
        Customer = customer;
    }
}
