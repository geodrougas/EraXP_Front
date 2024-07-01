namespace EraXp.Frontend.Models.Dto;

public record ContactDto(
    Guid? Id,
    Guid? DepartmentId,
    string Name,
    string Lastname,
    string Email,
    string PhoneNumber
)
{
    public string GetMailTo()
    {
        return $"mailto:{Email}";
    }
     
    public string GetTel()
    {
        return $"tel:{PhoneNumber}";
    }
}