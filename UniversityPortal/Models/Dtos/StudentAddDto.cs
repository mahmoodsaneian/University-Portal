namespace UniversityPortal.Models.Dtos;

public class StudentAddDto
{
    public string Username { get; set; }
    
    public string Password { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string PhoneNumber { get; set; }
    
    public string NationalCode { get; set; }
    
    public string EmailAddress { get; set; }
    
    public int StudentNumber { get; set; }
    
    public string FieldOfStudy { get; set; }
    
    public int EntryYear { get; set; }
}