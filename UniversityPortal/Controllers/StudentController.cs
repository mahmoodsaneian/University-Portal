using Microsoft.AspNetCore.Mvc;
using UniversityPortal.Models.Dtos;
using UniversityPortal.Models.Services;

namespace UniversityPortal.Controllers;

[Route("api/[controller]")]
[ApiController]

public class StudentController : ControllerBase
{
    private readonly StudentRepository _studentRepository;

    public StudentController(StudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_studentRepository.GetAll());
    }

    [HttpGet("{Id}")]
    public StudentGetDto Get(int Id)
    {
        return _studentRepository.Get(Id);
    }

    [HttpPost]
    public int Post([FromBody] StudentAddDto studentAddDto)
    {
        var result = _studentRepository.Add(new StudentDto()
        {
            TotalGrade = 0,
            Password = studentAddDto.Password,
            UserName = studentAddDto.Username,
            EmailAddress = studentAddDto.EmailAddress,
            PhoneNumber = studentAddDto.PhoneNumber,
            NationalCode = studentAddDto.NationalCode,
            EntryYear = studentAddDto.EntryYear,
            FieldOfStudy = studentAddDto.FieldOfStudy,
            FirstName = studentAddDto.FirstName,
            LastName = studentAddDto.LastName,
            StudentNumber = studentAddDto.StudentNumber
        });
        return result;
    }
}