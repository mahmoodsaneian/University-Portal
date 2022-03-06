namespace UniversityPortal.Models.Entities;

public class Education
{
    public int EducationId { get; set; }
    
    public string University { get; set; }
    
    public int GraduationYear { get; set; }
    
    public string FieldOfStudy { get; set; }
    
    public int TeacherId { get; set; }
}