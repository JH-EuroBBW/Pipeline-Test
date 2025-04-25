using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Pipeline.Models
{
    public class Miniature
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Table Ready")]
        public Boolean TableReady { get; set; } = false;
        public String Description { get; set; }
    }
}
