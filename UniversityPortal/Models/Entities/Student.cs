namespace UniversityPortal.Models.Entities;

public class Student
{
    public int StudentId { get; set; }
    
    public int StudentNumber { get; set; }
    
    public int EntryYear { get; set; }
    
    public double TotalGrade { get; set; }
    
    public string FieldOfStudy { get; set; }
}