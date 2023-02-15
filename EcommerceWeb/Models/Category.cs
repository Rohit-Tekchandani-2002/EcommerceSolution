using System.ComponentModel.DataAnnotations;
namespace EcommerceWeb.Models
{
    public class Category
    {
        [Key] // Annotation atribute 
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
