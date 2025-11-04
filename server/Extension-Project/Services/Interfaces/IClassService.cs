using Extension_Project.Models.Entities;

namespace Extension_Project.Services.Interfaces
{
    public interface IClassService
    {
        Task<IEnumerable<Class>> GetClassesByTeacherIdAsync(int teacherId);
    }
}
