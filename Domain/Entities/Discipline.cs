using Domain.Models;

namespace Domain.Entities
{
    public class Discipline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public int ClassesPerWeek { get; set; }
        public SchoolYear SchoolYear { get; set; }
        public KnowledgeArea KnowlegdeArea { get; set; }
    }
}