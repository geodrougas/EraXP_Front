using System.Text.Json.Serialization;
using EraXP_Back.Models.Domain.Enum;

namespace EraXp.Frontend.Models.Dto;

public record SignupTokenDto(
    [property: JsonPropertyName("ut")] UserType UserType,
    [property: JsonPropertyName("em")] string? Email,
    [property: JsonPropertyName("ed")] DateTimeOffset ExpirationDate
);