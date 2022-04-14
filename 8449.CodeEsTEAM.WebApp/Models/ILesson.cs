using System.ComponentModel.DataAnnotations;

namespace _8449.CodeEsTEAM.WebApp.Models
{
    public class ILesson
    {
        [Required]
        public String Name { get; set; }

        [Required]
        public String Overview { get; set; }

        [Required]
        public String Body { get; set; }

        public String Practice { get; set; }
    }
}
