using System.ComponentModel.DataAnnotations;

namespace Game.Shared.Models.Requests
{
    public class LeaveRoomModel
    {
        [Required]
        public required long PlayerId { get; set; }
    }
}
