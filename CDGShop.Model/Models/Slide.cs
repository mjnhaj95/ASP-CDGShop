using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDGShop.Model.Models
{
    [Table("Sildes")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(250)]
        public string Name { set; get; }

        [MaxLength(250)]
        public string Description { set; get; }

        [MaxLength(250)]
        public string Image { set; get; }

        [MaxLength(250)]
        public string URL { set; get; }

        public int? DisplayOrder { set; get; }
        public bool Status { set; get; }
    }
}