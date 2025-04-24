using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice2025_Gusev.Models
{
    public class Student
    {
        [Key]
        [Column("student_id")]
        public required int StudentId { get; set; }

        [Column("full_name")]
        public required string FullName { get; set; }

        [Column("year_admission")]
        public required int YearAdmission { get; set; }

        [Column("date_birth")]
        public required DateTime DateBirth { get; set; }

        [Column("group_id")]
        public required int GroupId { get; set; }


        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }
    }
}
