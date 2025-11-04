using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;

namespace Extension_Project.Models.Entities
{
    public class Manager
    {
        [Key]
        public int ManagerID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }

        public string SchoolName { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<SchoolClass> SchoolClasses { get; set; }
    }
}
