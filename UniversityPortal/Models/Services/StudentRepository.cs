using Microsoft.EntityFrameworkCore;
using UniversityPortal.Models.Contexts;
using UniversityPortal.Models.Dtos;
using UniversityPortal.Models.Entities;

namespace UniversityPortal.Models.Services;

public class StudentRepository
{
    private readonly DatabaseContext _context;

    public StudentRepository(DatabaseContext databaseContext)
    {
        _context = databaseContext;
    }

    public List<StudentGetDto> GetAll()
    {
        return _context.Students.Select(p => new StudentGetDto()
        {
            FirstName = p.User.FirstName,
            LastName = p.User.LastName,
            EntryYear = p.EntryYear,
            FieldOfStudy = p.FieldOfStudy,
            StudentNumber = p.StudentNumber,
            TotalGrade = p.TotalGrade
        }).ToList();
    }

    public StudentGetDto Get(int Id)
    {
        var student = _context.Students.Include(z => z.User).SingleOrDefault(p => p.StudentId == Id);

        return new StudentGetDto()
        {
            FirstName = student.User.FirstName,
            LastName = student.User.LastName,
            EntryYear = student.EntryYear,
            FieldOfStudy = student.FieldOfStudy,
            StudentNumber = student.StudentNumber,
            TotalGrade = student.TotalGrade
        };
    }

    public int Add(StudentDto studentDto)
    {
        Student newStudent = new Student()
        {
            StudentNumber = studentDto.StudentNumber,
            EntryYear = studentDto.EntryYear,
            FieldOfStudy = studentDto.FieldOfStudy,
            TotalGrade = studentDto.TotalGrade,
            User = new User()
            {
                FirstName = studentDto.FirstName,
                LastName = studentDto.LastName,
                EmailAddress = studentDto.EmailAddress,
                NationalCode = studentDto.NationalCode,
                Password = studentDto.Password,
                UserName = studentDto.UserName,
                PhoneNumber = studentDto.PhoneNumber
            }
        };

        _context.Students.Add(newStudent);
        _context.Users.Add(newStudent.User);
        _context.SaveChanges();

        return newStudent.StudentId;
    }
}