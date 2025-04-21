using System.ComponentModel.DataAnnotations;

namespace Practice2025_Gusev.Models
{
    public class Institute
    {
        [Key]public required int institut_id {  get; set; }
        public required string name_institute { get; set; }
        public required string full_name {  get; set; }
        public required string title_dean { get; set; }
    }
}
