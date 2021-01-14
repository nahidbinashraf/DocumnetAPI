using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DocumnetAPI.DTOModels
{
    public class DocumentUpdateDTO
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
