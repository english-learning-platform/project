using System.ComponentModel.DataAnnotations;
namespace Extension_Project.Models.Entities
{

    public enum UserRole
    {
        Admin,
        Teacher,
        Manager,
        Student,
        Parent
    }

    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public UserRole Role { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public Parent Parent { get; set; }
        public Manager Manager { get; set; }
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
    }
}



