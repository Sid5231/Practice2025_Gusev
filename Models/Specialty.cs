using System.ComponentModel.DataAnnotations;

namespace Practice2025_Gusev.Models
{
    public class Specialty
    {  
        [Key]public required int specialty_id { get; set; }
        public required string specialty_identifier { get; set; }
        public required string specialty_name { get; set; }
        public required int institut_id { get; set; }

    }
}
