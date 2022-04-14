using System.ComponentModel.DataAnnotations;

namespace _8449.CodeEsTEAM.WebApp.Models
{
    public class HTMLLesson : ILesson
    {
        [Key]
        public int ID { get; set; }
    }
}
