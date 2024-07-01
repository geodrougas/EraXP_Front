namespace EraXp.Frontend.Models.Dto;

public record AddressDto(
    Guid? Id,
    string Name,
    string GoogleLocationId,
    decimal Latitude,
    decimal Longitude
)
{
    public string GoogleMapsLocation = $"https://www.google.com/maps/search/?api=1&query={Latitude}%2C{Longitude}&query_place_id={GoogleLocationId}";
}