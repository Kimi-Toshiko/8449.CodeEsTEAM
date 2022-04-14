using System.ComponentModel.DataAnnotations;

namespace _8449.CodeEsTEAM.WebApp.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public String Description { get; set; }

        [Required]
        public int OneLessonTime { get; set; }

        [Required]
        public int TimeToComplete { get; set; }
        
        [Required]
        public int LessonsNumber { get; set; }

        [Required]
        public String LinkName { get; set; }
    }
}
