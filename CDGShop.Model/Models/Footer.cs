using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDGShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public int ID { set; get; }

        [Required]
        public string Contents { set; get; }
    }
}