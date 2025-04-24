using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice2025_Gusev.Models
{
    public class Group
    {
        [Key]
        [Column("group_id")]
        public required int GroupId { get; set; }

        [Column("group_number")]
        public required string GroupNumber { get; set; }

        [Column("institut_id")]
        public required int InstitutId { get; set; }

        [Column("specialty_id")]
        public required int SpecialtyId {  get; set; }

        [ForeignKey("SpecialtyId")]
        public virtual Specialty Specialty { get; set; }

        [ForeignKey("InstitutId")]
        public virtual Institute Institute { get; set; }
    }
}
