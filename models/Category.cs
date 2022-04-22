using System.ComponentModel.DataAnnotations;

namespace LeThanhNam.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name {get ; set ;}

       
    }
}