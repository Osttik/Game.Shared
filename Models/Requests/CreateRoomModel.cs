using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

#nullable disable

namespace Game.Shared.Models.Requests
{
    public class CreateRoomModel
    {
        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string Name { get; set; }
        [AllowNull]
        [MinLength(5)]
        public string Password { get; set; }
    }
}
