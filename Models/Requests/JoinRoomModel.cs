using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Game.Shared.Models.Requests
{
    public class JoinRoomModel
    {
        [Required]
        public long RoomId { get; set; }
        [Required]
        [MinLength(5)]
        public string Password { get; set; }
    }
}
