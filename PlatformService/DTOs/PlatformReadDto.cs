using System.ComponentModel.DataAnnotations;

namespace PlatformService.DTOs
{
    public class PlatformReadDto
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Publisher { get; set; }
        public required string Cost { get; set; }
    }
}
