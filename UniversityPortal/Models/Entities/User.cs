namespace UniversityPortal.Models.Entities;

public class User
{
    public int UserId { get; set; }
    
    public string UserName { get; set; }
    
    public string Password { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string PhoneNumber { get; set; }
    
    public string EmailAddress { get; set; }
    
    public string NationalCode { get; set; }
    
    public Student Student { get; set; }
    
    public Teacher Teacher { get; set; }
    
    public Manager Manager { get; set; }
}