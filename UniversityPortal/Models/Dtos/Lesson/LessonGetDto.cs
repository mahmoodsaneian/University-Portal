using UniversityPortal.Models.Entities;

namespace UniversityPortal.Models.Dtos.Lesson;

public class LessonGetDto
{
    public int LessonId { get; set; }
    
    public string Name { get; set; }
    
    public string Type { get; set; }
    
    public int Unit { get; set; }
}