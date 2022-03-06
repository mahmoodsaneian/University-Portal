namespace UniversityPortal.Models.Entities;

public class PrerequisitesLesson
{
    public int Id { get; set; }
    
    public int LessonId { get; set; }
    
    public int PrerequisitesLessonId { get; set; }
    
    public Lesson Lesson { get; set; }
}