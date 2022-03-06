namespace UniversityPortal.Models.Entities;

public class StudentClass
{
    public int Id { get; set; }
    
    public int StudentId { get; set; }
    
    public int ClassRoomId { get; set; }
    
    public float Grade { get; set; }
}