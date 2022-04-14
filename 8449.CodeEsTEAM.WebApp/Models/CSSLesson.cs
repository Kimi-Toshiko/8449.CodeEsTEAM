using System.ComponentModel.DataAnnotations;

namespace _8449.CodeEsTEAM.WebApp.Models
{
    public class CSSLesson : ILesson
    {
        [Key]
        public int ID { get; set; }
    }
}
