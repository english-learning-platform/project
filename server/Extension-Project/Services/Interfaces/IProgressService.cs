namespace Extension_Project.Services.Interfaces
{
    public interface IProgressService
    {
        Task<decimal> GetStudentProgressComparedToClassAsync(int studentId, int lessonId);
        Task<decimal> GetStudentLessonProgressAsync(int studentId, int lessonId);
        Task<Dictionary<string, decimal>> GetStudentProgressByTopicAsync(int studentId);
        Task<decimal> GetClassProgressByLessonAsync(int classId, int lessonId);
        Task AddStudentProgressAsync(int studentId, int lessonId, decimal initialScore = 0);
        Task UpdateStudentProgressAsync(int studentId, int lessonId, decimal score);
    }
}
