namespace EraXp.Frontend.Models.Dto;

public record CourseDto(
    Guid? Id, Guid? DepartmentId, string Semester, string Name, string Description, decimal Ects
);