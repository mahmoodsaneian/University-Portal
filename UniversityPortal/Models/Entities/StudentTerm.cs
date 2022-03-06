namespace UniversityPortal.Models.Entities;

public class StudentTerm
{
    public int Id { get; set; }
    
    public int StudentId { get; set; }
    
    public int TermId { get; set; }

    public float AverageOfGrades { get; set; }
}