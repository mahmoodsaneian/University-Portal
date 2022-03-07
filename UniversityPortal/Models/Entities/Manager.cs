namespace UniversityPortal.Models.Entities;

public class Manager
{
    public string Post { get; set; }
    
    public int ManagerId { get; set; }
    
    public int UserId { get; set; }
    
    public User User { get; set; }
}