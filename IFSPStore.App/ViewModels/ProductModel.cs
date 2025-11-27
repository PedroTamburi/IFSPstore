namespace IFSPStore.App.ViewModels;

public record ProductModel(
    int Id,
    string Name,
    decimal Value,
    int Quantity,
    DateTime PurchaseDate,
    string SaleUnity,
    string GroupName,
    int GroupId
);
