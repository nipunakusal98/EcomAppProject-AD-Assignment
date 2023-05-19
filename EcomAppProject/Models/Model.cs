using System.ComponentModel.DataAnnotations;

namespace EcomAppProject.Models
{
    public class Model
    {
        [Key]
        public int ModelID { get; set; }

        [Display (Name = "ModelName")]
        [Required (ErrorMessage ="Required ")]
        public string ModelName { get; set; }

        [Display(Name = "ModelPictureURL")]
        [Required(ErrorMessage = "Required ")]
        public string ModelPictureURL { get; set; }

        [Display(Name = "DefaultRAM")]
        [Required(ErrorMessage = "Required ")]
        public string DefaultRAM { get; set; }


        [Display(Name = "DefaultVGA")]
        [Required(ErrorMessage = "Required ")]
        public string DefaultVGA { get; set; }

        [Display(Name = "DefaultProcessor")]
        [Required(ErrorMessage = "Required ")]
        public string DefaultProcessor { get; set; }

        [Display(Name = "DefaultOS")]
        [Required(ErrorMessage = "Required ")]
        public string DefaultOS { get; set; }

        [Display(Name = "DefaultAntivirus")]
        [Required(ErrorMessage = "Required ")]
        public string DefaultAntivirus { get; set; }

        [Display(Name = "DefaultModelPrice")]
        [Required(ErrorMessage = "Required ")]
        public int DefaultModelPrice { get; set; }

        // Foreign key
        public int SeriesID { get; set; }
        public Series Series { get; set; }  // Navigation properties

        // Navigation properties
        public List<CustomerConfiguration> CustomerConfigurations { get; set; }

    }
}
