using System.ComponentModel.DataAnnotations;

namespace Game.Shared.Models.Requests
{
    public class JoinRoomModel
    {
        [Required]
        public required long PlayerId { get; set; }
        [Required]
        public required long RoomId { get; set; }
        [Required]
        [MinLength(5)]
        public required string Password { get; set; }
    }
}
