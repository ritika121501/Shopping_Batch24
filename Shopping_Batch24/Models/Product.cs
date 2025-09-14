using Shopping_Batch24.Migrations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_Batch24.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public double Price { get; set; }
        [ForeignKey("Category")]
        public int CategoryId {  get; set; }
        public Category Category { get; set; }  
        public bool IsActive { get; set; }
    }
}
