namespace UniversityPortal.Models.Entities;

public class Term
{
    public int TermId { get; set; }
    
    public DateTime StartTime { get; set; }
    
    public DateTime EndTime { get; set; }
    
    public ICollection<StudentTerm> StudentTerms { get; set; }
    
    public ICollection<ClassRoom> ClassRooms { get; set; }
}