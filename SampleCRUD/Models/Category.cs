using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SampleCRUD.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [Length(1, 40, ErrorMessage =" Category name should between 8 to 40 charactor")]
        public required string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage ="Display order should between 1 and 100")]
        public int DisplayOrder { get; set; }
    }
}
