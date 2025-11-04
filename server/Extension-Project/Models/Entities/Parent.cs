using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Extension_Project.Models.Entities
{
    public class Parent
    {
        [Key]
        public int ParentID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }

        public ICollection<ParentStudent> ParentStudents { get; set; }
    }
}
