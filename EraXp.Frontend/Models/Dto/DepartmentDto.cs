namespace EraXp.Frontend.Models.Dto;

public record DepartmentDto(
    Guid? Id,
    Guid? UniversityId,
    string Name,
    string Description,
    List<ContactDto>? Contacts,
    List<CourseDto>? Courses
)
{
    public override string ToString()
    {
        return Name;
    }
    
    public IDictionary<string, List<CourseDto>> CoursesMap
    {
        get
        {
            if (Courses == null)
                return new Dictionary<string, List<CourseDto>>(0);

            return Courses
                .GroupBy(m => m.Semester)
                .ToDictionary(m => m.Key, m => m.ToList());
        }
    }
}