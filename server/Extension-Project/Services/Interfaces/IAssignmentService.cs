using Extension_Project.Models.Entities;

namespace Extension_Project.Services.Interfaces
{
    public interface IAssignmentService
    {
        Task<IEnumerable<Assignment>> GetAllAssignmentsAsync();
        Task<IEnumerable<Assignment>> GetAssignmentsByTypeAsync(string type);
        Task<IEnumerable<Assignment>> GetAssignmentsByTeacherAsync(int teacherId);
        Task<Assignment> CreateAssignmentAsync(Assignment assignment);
        Task<bool> AssignToLessonAsync(int assignmentId, int lessonId);
        Task<IEnumerable<Assignment>> GetAssignmentsByLessonAsync(int lessonId);
    }
}
