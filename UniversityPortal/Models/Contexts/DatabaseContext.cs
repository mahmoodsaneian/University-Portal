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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Relation between Education & Teacher tables
        modelBuilder.Entity<Education>().HasOne(p => p.Teacher)
            .WithMany(p => p.Educations)
            .HasForeignKey(p => p.TeacherId);

        //Relation between ClassTime & ClassRoom tables
        modelBuilder.Entity<ClassTime>()
            .HasOne(p => p.ClassRoom)
            .WithMany(p => p.ClassTimes)
            .HasForeignKey(p => p.ClassRoomId);
        
        //Relation between Student & ClassRoom tables
        modelBuilder.Entity<StudentClass>()
            .HasOne(p => p.Student)
            .WithMany(p => p.StudentClasses)
            .HasForeignKey(p => p.StudentId);

        modelBuilder.Entity<StudentClass>()
            .HasOne(p => p.ClassRoom)
            .WithMany(p => p.StudentClasses)
            .HasForeignKey(p => p.ClassRoomId);
        
        //Relation between Student & Term tables
        modelBuilder.Entity<StudentTerm>()
            .HasOne(p => p.Student)
            .WithMany(p => p.StudentTerms)
            .HasForeignKey(p => p.StudentId);

        modelBuilder.Entity<StudentTerm>()
            .HasOne(p => p.Term)
            .WithMany(p => p.StudentTerms)
            .HasForeignKey(p => p.TermId);
        
        //Relation between Lesson & PrerequisitesLesson
        modelBuilder.Entity<PrerequisitesLesson>()
            .HasOne(p => p.Lesson)
            .WithMany(p => p.PrerequisitesLessons)
            .HasForeignKey(p => p.LessonId);
    }
}