using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Extension_Project.Models.Entities
{
    public class Topic
    {
        [Key]
        public int TopicID { get; set; }
        public string Name { get; set; }

        public ICollection<Lesson> Lessons { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }
}
