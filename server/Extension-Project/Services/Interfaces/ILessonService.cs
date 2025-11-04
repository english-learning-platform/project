using Extension_Project.Models.Entities;

namespace Extension_Project.Services.Interfaces
{
    public interface ILessonService
    {
        Task<IEnumerable<Lesson>> GetAllLessonsAsync();
        Task<Lesson> GetLessonByIdAsync(int lessonId);
        Task<IEnumerable<Lesson>> GetLessonsByClassIdAsync(int classId);
        Task<IEnumerable<Lesson>> GetLessonsByTeacherIdAsync(int teacherId);
        Task<Lesson> CreateLessonAsync(Lesson lesson);
        Task<bool> AssignLessonToClassAsync(int lessonId, int classId);
    }
}
