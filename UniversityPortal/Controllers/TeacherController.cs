using Microsoft.AspNetCore.Mvc;
using UniversityPortal.Models.Dtos;
using UniversityPortal.Models.Services;

namespace UniversityPortal.Controllers;

[Route("api/[controller]")]
[ApiController]

public class TeacherController : ControllerBase
{
    private readonly TeacherRepository _teacherRepository;

    public TeacherController(TeacherRepository teacherRepository)
    {
        _teacherRepository = teacherRepository;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_teacherRepository.GetAll());
    }

    [HttpGet("{id}")]
    public TeacherGetDto Get(int Id)
    {
        return _teacherRepository.Get(Id);
    }
    
    [HttpPost]
    public int Post([FromBody] TeacherAddDto teacherAddDto)
    {
        var result = _teacherRepository.Add(new TeacherDto()
        {
            Username = teacherAddDto.Username,
            Password = teacherAddDto.Password,
            EmailAddress = teacherAddDto.EmailAddress,
            FirstName = teacherAddDto.FirstName,
            LastName = teacherAddDto.LastName,
            NationalCode = teacherAddDto.NationalCode,
            PhoneNumber = teacherAddDto.PhoneNumber
        });
        return result;
    }
}