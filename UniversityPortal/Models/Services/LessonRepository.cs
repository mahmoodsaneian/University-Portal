using UniversityPortal.Models.Contexts;
using UniversityPortal.Models.Dtos.Lesson;
using UniversityPortal.Models.Entities;

namespace UniversityPortal.Models.Services;

public class LessonRepository
{
    private readonly DatabaseContext _context;

    public LessonRepository(DatabaseContext context)
    {
        _context = context;
    }

    public List<LessonGetDto> GetAll()
    {
        return _context.Lessons.Select(p => new LessonGetDto()
        {
            LessonId = p.LessonId,
            Name = p.Name,
            Type = p.Type,
            Unit = p.Unit
        }).ToList();
    }

    public LessonGetDto Get(int Id)
    {
        var lesson = _context.Lessons.SingleOrDefault(p => p.LessonId == Id);
        return new LessonGetDto()
        {
            LessonId = lesson.LessonId,
            Name = lesson.Name,
            Type = lesson.Type,
            Unit = lesson.Unit
        };
    }

    public int Add(LessonAddDto lessonDto)
    {
        Lesson newLesson = new Lesson()
        {
            Name = lessonDto.Name,
            Type = lessonDto.Type,
            Unit = lessonDto.Unit
        };

        _context.Lessons.Add(newLesson);
        _context.SaveChanges();

        return newLesson.LessonId;
    }
}