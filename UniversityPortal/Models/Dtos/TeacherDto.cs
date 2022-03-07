using UniversityPortal.Models.Entities;

namespace UniversityPortal.Models.Dtos;

public class TeacherDto
{
    
    public int Rank { get; set; }

    public string Username { get; set; }
    
    public string Password { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string PhoneNumber { get; set; }
    
    public string EmailAddress { get; set; }
    
    public string NationalCode { get; set; }
}