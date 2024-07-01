namespace EraXp.Frontend.Models.Dto;

public record UniversityLanguage(
    Guid Id,
    string Language,
    List<Tuple<string, decimal>> LanguageSkills
);