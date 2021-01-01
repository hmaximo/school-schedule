using System.Collections.Generic;
using Domain.Models;

namespace Domain.Entities
{
    public class StudentGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SchoolYear SchoolYear { get; set; }
        public int ClassesPerWeek { get; set; }
        public List<Discipline> Disciplines { get; set; }
    }
}