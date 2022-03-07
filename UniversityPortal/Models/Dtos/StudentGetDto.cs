namespace UniversityPortal.Models.Dtos;

public class StudentGetDto
{
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public int StudentNumber { get; set; }
    
    public string FieldOfStudy { get; set; }
    
    public int EntryYear { get; set; }
    
    public double TotalGrade { get; set; }
}