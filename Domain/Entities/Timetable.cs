using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Timetable
    {
        public int Id { get; set; }
        public int StudentGroupId { get; set; }
        public StudentGroup StudentGroup { get; set; }
        public int NumberOfWeekDays { get; set; }
        public int ClassesPerDay { get; set; }
        [NotMapped]
        public List<List<Discipline>> DisciplinesSortedInTimetable { get; set; }
    }
}