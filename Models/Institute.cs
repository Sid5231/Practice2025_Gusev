using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice2025_Gusev.Models
{
    public class Institute
    {
        [Key]
        [Column("institut_id")]
        public required int InstitutId {  get; set; }

        [Column("name_institute")]
        public required string NameInstitute { get; set; }

        [Column("full_name")]
        public required string FullName {  get; set; }

        [Column("title_dean")]
        public required string TitleDean { get; set; }
    }
}
