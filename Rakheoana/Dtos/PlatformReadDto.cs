using System.ComponentModel.DataAnnotations;

namespace Rakheoana.Dtos
{
       public class PlatformReadDto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Publisher { get; set; }
        [Required]
        public string Cost { get; set; }
    }
}