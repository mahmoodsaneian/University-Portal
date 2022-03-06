namespace UniversityPortal.Models.Entities;

public class StudentClass
{
    public int Id { get; set; }
    
    public int StudentId { get; set; }
    
    public int ClassRoomId { get; set; }
    
    public float Grade { get; set; }
    
    public Student Student { get; set; }
    
    public ClassRoom ClassRoom { get; set; }
}