using Microsoft.AspNetCore.Mvc;
using UniversityPortal.Models.Dtos.Lesson;
using UniversityPortal.Models.Services;

namespace UniversityPortal.Controllers;

[Route("api/[controller]")]
[ApiController]

public class LessonController : ControllerBase
{
    private readonly LessonRepository _lessonRepository;

    public LessonController(LessonRepository lessonRepository)
    {
        _lessonRepository = lessonRepository;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_lessonRepository.GetAll());
    }

    [HttpGet("{Id}")]
    public LessonGetDto Get(int Id)
    {
        return _lessonRepository.Get(Id);
    }

    [HttpPost]
    public int Post(LessonAddDto lessonAddDto)
    {
        var result = _lessonRepository.Add(lessonAddDto);
        return result;
    }
}