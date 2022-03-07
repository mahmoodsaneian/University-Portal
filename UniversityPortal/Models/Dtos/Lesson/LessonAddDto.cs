using UniversityPortal.Models.Entities;

namespace UniversityPortal.Models.Dtos.Lesson;

public class LessonAddDto
{
    public string Name { get; set; }
    
    public int Unit { get; set; }
    
    public string Type { get; set; }
}