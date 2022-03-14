namespace UniversityPortal.Models.Entities;

public class Lesson
{
    public int LessonId { get; set; }
    
    public string Name { get; set; }
    
    public int Unit { get; set; }
    
    public string Type { get; set; }
    
    public ICollection<PrerequisitesLesson> PrerequisitesLessons { get; set; }
    
    public ICollection<ClassRoom> ClassRooms { get; set; }
}