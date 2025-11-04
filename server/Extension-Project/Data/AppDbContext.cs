using Extension_Project.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Extension_Project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<ParentStudent> ParentStudents { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<SchoolClass> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<ClassLesson> ClassLessons { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<LessonAssignment> LessonTasks { get; set; }
        public DbSet<Progress> Progress { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParentStudent>()
                .HasKey(ps => new { ps.ParentID, ps.StudentID });

            modelBuilder.Entity<ClassLesson>()
                .HasKey(cl => new { cl.SchoolClassID, cl.LessonID });

            modelBuilder.Entity<LessonAssignment>()
                .HasKey(la => new { la.LessonID, la.AssignmentID });

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany()
                .HasForeignKey(m => m.SenderID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Receiver)
                .WithMany()
                .HasForeignKey(m => m.ReceiverID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
