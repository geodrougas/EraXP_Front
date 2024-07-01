using EraXP_Back.Models.Dto;

namespace EraXp.Frontend.Models.Dto;

public record SignUpDto(
    string Username,
    string Password,
    string PasswordRepeat,
    string Email,
    UniversityInfoDto? UniInfoDto
);