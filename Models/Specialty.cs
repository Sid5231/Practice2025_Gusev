using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice2025_Gusev.Models
{
    public class Specialty
    {  
        [Key]
        [Column("specialty_id")]
        public required int SpecialtyId { get; set; }

        [Column("specialty_identifier")]
        public required string SpecialtyIdentifier { get; set; }

        [Column("specialty_name")]
        public required string SpecialtyName { get; set; }

        [Column("institut_id")]
        public required int InstitutId { get; set; }

    }
}
