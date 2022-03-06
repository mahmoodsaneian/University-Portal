namespace UniversityPortal.Models.Entities;

public class Teacher 
{
    public int TeacherId { get; set; }

    public int Rank { get; set; }

    public ICollection<Education> Educations { get; set; }
    
    public int UserId { get; set; }
    
    public User User { get; set; }
}