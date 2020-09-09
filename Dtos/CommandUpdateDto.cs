using System.ComponentModel.DataAnnotations;

namespace Kommander.Dtos
{
    public class CommandUpdateDto
    {
        //public int Id { get; set; }
        [Required]
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }
    }
}
