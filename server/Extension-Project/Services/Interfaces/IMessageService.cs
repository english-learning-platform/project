using Extension_Project.Models.Entities;

namespace Extension_Project.Services.Interfaces
{
    public interface IMessageService
    {
        Task<Message> AddMessageAsync(Message message);
        Task<IEnumerable<Message>> GetMessagesByStudentIdAsync(int studentId);
    }
}
