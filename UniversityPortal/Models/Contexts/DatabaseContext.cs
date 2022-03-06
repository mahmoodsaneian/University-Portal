using Microsoft.EntityFrameworkCore;

namespace UniversityPortal.Models.Contexts;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options) : base(options)
    {
        
    }
}