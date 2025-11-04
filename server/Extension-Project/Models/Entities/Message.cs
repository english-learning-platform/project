using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Extension_Project.Models.Entities
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }

        [ForeignKey("Sender")]
        public int SenderID { get; set; }
        public User Sender { get; set; }

        [ForeignKey("Receiver")]
        public int ReceiverID { get; set; }
        public User Receiver { get; set; }

        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
