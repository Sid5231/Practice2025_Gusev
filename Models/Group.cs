using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice2025_Gusev.Models
{
    public class Group
    {
        [Key]public required int group_id { get; set; }
        public required string group_number { get; set; }
        public required int institut_id { get; set; }
        public required int specialty_id {  get; set; }

        [ForeignKey("specialty_id")]
        public virtual Specialty Specialty { get; set; }

        [ForeignKey("institut_id")]
        public virtual Institute Institute { get; set; }
    }
}
