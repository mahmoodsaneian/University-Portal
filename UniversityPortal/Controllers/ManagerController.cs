using Microsoft.AspNetCore.Mvc;
using UniversityPortal.Models.Dtos;
using UniversityPortal.Models.Services;

namespace UniversityPortal.Controllers;

[Route("api/[controller]")]
[ApiController]

public class ManagerController : ControllerBase
{
    private readonly ManagerRepository _managerRepository;

    public ManagerController(ManagerRepository managerRepository)
    {
        _managerRepository = managerRepository;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_managerRepository.GetAll());
    }

    [HttpGet("{Id}")]
    public ManagerGetDto Get(int Id)
    {
        return _managerRepository.Get(Id);
    }

    [HttpPost]
    public int Post(ManagerAddDto managerAddDto)
    {
        var result = _managerRepository.Add(managerAddDto);
        return result;
    }
}