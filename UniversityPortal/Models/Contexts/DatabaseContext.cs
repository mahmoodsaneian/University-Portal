using Microsoft.EntityFrameworkCore;
using UniversityPortal.Models.Entities;

namespace UniversityPortal.Models.Contexts;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options) : base(options)
    {
        
    }
    
    //Create Tables
    public DbSet<Lesson> Lessons { get; set; }
    
    public DbSet<PrerequisitesLesson> PrerequisitesLessons { get; set; }
    
    public DbSet<ClassRoom> ClassRooms { get; set; }
    
    public DbSet<ClassTime> ClassTimes { get; set; }
    
    public DbSet<User> Users { get; set; }
    
    public DbSet<Teacher> Teachers { get; set; }
    
    public DbSet<Education> Education { get; set; }
    
    public DbSet<Student> Students { get; set; }

    public DbSet<Term> Terms { get; set; }

    public DbSet<StudentClass> StudentClasses { get; set; }
    
    public DbSet<StudentTerm> StudentTerms { get; set; }
}