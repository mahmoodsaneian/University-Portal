using Microsoft.EntityFrameworkCore;
using UniversityPortal.Models.Contexts;
using UniversityPortal.Models.Dtos;
using UniversityPortal.Models.Entities;

namespace UniversityPortal.Models.Services;

public class ManagerRepository
{
    private readonly DatabaseContext _context;

    public ManagerRepository(DatabaseContext context)
    {
        _context = context;
    }

    public List<ManagerGetDto> GetAll()
    {
        return _context.Managers.Select(p => new ManagerGetDto()
        {
            FirstName = p.User.FirstName,
            LastName = p.User.LastName,
            EmailAddress = p.User.EmailAddress,
            Post = p.Post
        }).ToList();
    }

    public ManagerGetDto Get(int Id)
    {
        var manager = _context.Managers.Include(z => z.User).SingleOrDefault(p => p.ManagerId == Id);

        return new ManagerGetDto()
        {
            FirstName = manager.User.FirstName,
            LastName = manager.User.LastName,
            EmailAddress = manager.User.EmailAddress,
            Post = manager.Post
        };
    }

    public int Add(ManagerAddDto managerAddDto)
    {
        Manager newManager = new Manager()
        {
            Post = managerAddDto.Post,
            User = new User()
            {
                UserName = managerAddDto.Username,
                Password = managerAddDto.Password,
                FirstName = managerAddDto.FirstName,
                LastName = managerAddDto.Lastname,
                EmailAddress = managerAddDto.EmailAddress,
                PhoneNumber = managerAddDto.PhoneNumber,
                NationalCode = managerAddDto.NationalCode
            }
        };

        _context.Managers.Add(newManager);
        _context.Users.Add(newManager.User);
        _context.SaveChanges();

        return newManager.ManagerId;
    }
}