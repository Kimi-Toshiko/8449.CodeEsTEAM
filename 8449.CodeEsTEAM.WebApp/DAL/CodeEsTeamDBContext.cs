using _8449.CodeEsTEAM.WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace _8449.CodeEsTEAM.WebApp.DAL
{
    public class CodeEsTeamDBContext : DbContext
    {
        public CodeEsTeamDBContext(DbContextOptions<CodeEsTeamDBContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<HTMLLesson> HTMLLessons { get; set; }

        public DbSet<CSSLesson> CSSLessons { get; set; }

        public DbSet<JSLesson> JSLessons { get; set; }
    }
}
