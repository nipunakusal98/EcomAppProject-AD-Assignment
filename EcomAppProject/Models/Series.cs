using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcomAppProject.Models
{
    public class Series
    {
        [Key]
        public int SeriesID { get; set; }
        public string SeriesName { get; set; }
        public string SeriesPictureURL { get; set; }

        // Foreign key

        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; } // Navigation properties

        // Navigation properties
        public List<Model> Models { get; set; }

    }
}
