using System.ComponentModel.DataAnnotations;

namespace LeThanhNam.Models
{
    public class Comment
    {
        public int ID { get; set; }
       [Required]
        public string Content {get ; set ;}
        [Required]
        public string Author { get ; set;}

        public DateTime CreateAt {get ; set ;}
    }
}