namespace UniversityPortal.Models.Entities;

public class ClassRoom
{
    public int ClassRoomId { get; set; }
    
    public int TeacherId { get; set; }
    
    public int LessonId { get; set; }
    
    public int TermId { get; set; }
    
    public ICollection<ClassTime> ClassTimes { get; set; }
    
    public ICollection<StudentClass> StudentClasses { get; set; }
    
    public Teacher Teacher { get; set; }
    
    public Lesson Lesson { get; set; }
    
    public Term Term { get; set; }
}