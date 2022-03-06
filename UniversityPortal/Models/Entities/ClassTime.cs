namespace UniversityPortal.Models.Entities;

public class ClassTime
{
    public int ClassTimeId { get; set; }
    
    public string Day { get; set; }
    
    public DateTime StartTime { get; set; }
    
    public DateTime EndTime { get; set; }
    
    public int ClassNumber { get; set; }
    
    public int ClassRoomId { get; set; }   
}