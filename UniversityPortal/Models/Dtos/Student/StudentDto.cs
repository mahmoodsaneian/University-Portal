namespace UniversityPortal.Models.Dtos;

public class StudentDto
{
    public double TotalGrade { get; set; }

    public int StudentNumber { get; set; }
    
    public string FieldOfStudy { get; set; }
    
    public int EntryYear { get; set; }
    
    public string UserName { get; set; }
    
    public string Password { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string EmailAddress { get; set; }
    
    public string PhoneNumber { get; set; }
    
    public string NationalCode { get; set; }
}