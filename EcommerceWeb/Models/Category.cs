using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace EcommerceWeb.Models
{
    public class Category
    {
        [Key] // Annotation atribute 
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        //Custom Validation 
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Display Order Must be beetween 1 and 100 only!!")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
