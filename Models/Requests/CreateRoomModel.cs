using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Game.Shared.Models.Requests
{
    public class CreateRoomModel
    {
        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public required string Name { get; set; }
        [AllowNull]
        [MinLength(5)]
        public string? Password { get; set; }
        [Required]
        public required long PlayerId { get; set; }
    }
}
