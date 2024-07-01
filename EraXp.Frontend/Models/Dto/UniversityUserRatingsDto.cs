namespace EraXp.Frontend.Models.Dto;

public record UniversityUserRatingsDto
(
    string? Username,
    Guid UniversityId,
    int Stars,
    string Comment
);