using Extension_Project.Models.Entities;

namespace Extension_Project.Services.Interfaces
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetStudentsByClassIdAsync(int classId);
        Task<Student> GetStudentByIdAsync(int studentId);
    }
}
