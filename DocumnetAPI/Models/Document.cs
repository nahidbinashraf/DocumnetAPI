using System.ComponentModel.DataAnnotations;

namespace DocumnetAPI.Models
{
    public class Document
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string HowTo { get; set; }
        [Required]
        public string LineNo { get; set; }
        [Required]
        [MaxLength(250)]
        public string Platform { get; set; }
    }
}
