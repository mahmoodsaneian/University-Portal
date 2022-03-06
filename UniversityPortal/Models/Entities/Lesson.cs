namespace UniversityPortal.Models.Entities;

public class Lesson
{
    public int LessonId { get; set; }
    
    public string Name { get; set; }
    
    public int Unit { get; set; }
    
    public Type Type { get; set; }
    
    public ICollection<PrerequisitesLesson> PrerequisitesLessons { get; set; }
}