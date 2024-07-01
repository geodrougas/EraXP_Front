using System.Text.Json;
using EraXP_Back.Models.Dto;
using EraXp.Frontend.Views.Pages;

namespace EraXp.Frontend.Models.Dto;

public record UniversityDto(
    Guid? Id,
    string Name,
    string Description,
    UniversityLanguage Language,
    Guid? UserDepartment,
    Guid? ThumbnailId,
    AddressDto? AddressDto,
    List<UniversityPhotoDto>? PhotoMetadata,
    List<DepartmentDto>? Departments
)
{
    public override string ToString()
    {
        return Name;
    }

    public string GetUniversityUrl()
    {
        return $"/university/{Id}";
    }

    public string? GetImageUrl(string? baseUrl)
    {
        if (ThumbnailId == null)
            return null;
        return Path.Combine(baseUrl, $"photo/{ThumbnailId}");
    }
}