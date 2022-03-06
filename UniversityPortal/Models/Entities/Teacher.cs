namespace UniversityPortal.Models.Entities;

public class Teacher : User
{
    public int TeacherId { get; set; }

    public int Rank { get; set; }

    public ICollection<Education> Educations { get; set; }
}