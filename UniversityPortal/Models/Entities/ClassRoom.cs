namespace UniversityPortal.Models.Entities;

public class ClassRoom
{
    public int ClassId { get; set; }
    
    public int TeacherId { get; set; }
    
    public int LessonId { get; set; }
    
    public int TermId { get; set; }
    
    public ICollection<ClassTime> ClassTimes { get; set; }
    
    public ICollection<StudentClass> StudentClasses { get; set; }
}