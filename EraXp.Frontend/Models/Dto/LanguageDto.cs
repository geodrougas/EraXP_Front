namespace EraXp.Frontend.Models.Dto;

public record LanguageDto(
    Guid Id,
    string Name
)
{
    public override string ToString()
    {
        return Name;
    }
}