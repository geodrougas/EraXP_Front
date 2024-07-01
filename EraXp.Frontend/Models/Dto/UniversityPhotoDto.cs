namespace EraXp.Frontend.Models.Dto;

public record UniversityPhotoDto(
    Guid? Id,
    Guid? UniversityId,
    Guid? PhotoId,
    string? Uri
);
