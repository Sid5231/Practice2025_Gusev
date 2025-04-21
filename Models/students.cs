using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice2025_Gusev.Models
{
    public class Students
    {
        [Key]public required int student_id { get; set; }
        public required string full_name { get; set; }
        public required int year_admission { get; set; }
        public required DateTime date_birth { get; set; }
        
        [ForeignKey("group_id")]
        public virtual Group Group { get; set; }
    }
}
