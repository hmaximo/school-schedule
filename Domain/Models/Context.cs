using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Domain.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; Database=school-schedule;" +
                                        "User Id=SA; Password=3ncr1pt@D4n");
        }
        public DbSet<Domain.Entities.Discipline> Discipline { get; set; }
        public DbSet<Domain.Entities.Professor> Professor { get; set; }
        public DbSet<Domain.Entities.StudentGroup> StudentGroup { get; set; }
        public DbSet<Domain.Entities.Timetable> Timetable { get; set; }
    }
}