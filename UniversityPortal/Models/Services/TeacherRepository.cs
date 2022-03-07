using Microsoft.EntityFrameworkCore;
using UniversityPortal.Models.Contexts;
using UniversityPortal.Models.Dtos;
using UniversityPortal.Models.Entities;

namespace UniversityPortal.Models.Services;

public class TeacherRepository
{
    private readonly DatabaseContext _context;

    public TeacherRepository(DatabaseContext context)
    {
        _context = context;
    }

    public List<TeacherGetDto> GetAll()
    {
        return _context.Teachers.Select(p => new TeacherGetDto()
        {
            FirstName = p.User.FirstName,
            LastName = p.User.LastName,
            EmailAddress = p.User.EmailAddress,
            PhoneNumber = p.User.PhoneNumber,
            Rank = p.Rank
        }).ToList();
    }

    public TeacherGetDto Get(int Id)
    {
        var teacher = _context.Teachers.Include(z=> z.User).SingleOrDefault(p => p.TeacherId == Id);
        return new TeacherGetDto()
        {
            FirstName = teacher.User.FirstName,
            LastName = teacher.User.LastName,
            EmailAddress = teacher.User.LastName,
            PhoneNumber = teacher.User.PhoneNumber,
            Rank = teacher.Rank
        };
    }
    
    public int Add(TeacherDto teacherDto)
    {
        
        Teacher newTeacher = new Teacher()
        {
            Rank = 1,
            Educations = new List<Education>(),
            User = new User()
            {
                FirstName = teacherDto.FirstName,
                LastName = teacherDto.LastName,
                EmailAddress = teacherDto.EmailAddress,
                NationalCode = teacherDto.NationalCode,
                UserName = teacherDto.Username,
                Password = teacherDto.Password,
                PhoneNumber = teacherDto.PhoneNumber
            }
        };
        //Save to database
        _context.Teachers.Add(newTeacher);
        _context.Users.Add(newTeacher.User);
        _context.SaveChanges();

        return newTeacher.TeacherId;
    }
}



