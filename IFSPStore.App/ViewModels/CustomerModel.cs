namespace IFSPStore.App.ViewModels;

public record CustomerModel(
    int Id,
    string Name,
    string Document,
    string Address,
    string Neighborhood,
    string CityName,
    int CityId
);
