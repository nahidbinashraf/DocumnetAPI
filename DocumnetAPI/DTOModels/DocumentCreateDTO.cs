using System.ComponentModel.DataAnnotations;

namespace DocumnetAPI.DTOModels
{
    public class DocumentCreateDTO
    {
        [Required]
        public string HowTo { get; set; }
        [Required]
        public string LineNo { get; set; }
        [Required]
        [MaxLength(250)]
        public string Platform { get; set; }
    }
}
