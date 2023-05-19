using System.ComponentModel.DataAnnotations;

namespace EcomAppProject.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryPictureURL { get; set; }

        // Navigation properties
        public List<Series> Series { get; set; }

    }
}
