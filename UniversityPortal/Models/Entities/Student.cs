namespace UniversityPortal.Models.Entities;

public class Student
{
    public int StudentId { get; set; }
    
    public int StudentNumber { get; set; }
    
    public int EntryYear { get; set; }
    
    public double TotalGrade { get; set; }
    
    public string FieldOfStudy { get; set; }
    
    public ICollection<StudentClass> StudentClasses { get; set; }
    
    public ICollection<StudentTerm> StudentTerms { get; set; }
    
    public int UserId { get; set; }
    
    public User User { get; set; }
}