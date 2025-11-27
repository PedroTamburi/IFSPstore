using IFSPStore.Domain.Entities;
namespace IFSPStore.App.ViewModels;

public record SaleModel(
    int Id,
    DateTime Date,
    decimal TotalValue,
    string SalesmanName,
    int SalesmanId,
    string CustomerName,
    int CustomerId,
    List<SaleItem> Items
);
