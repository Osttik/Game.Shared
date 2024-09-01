using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Game.Shared.Models.Requests
{
    public class LeaveRoomModel
    {
        [Required]
        public long PlayerId { get; set; }
    }
}