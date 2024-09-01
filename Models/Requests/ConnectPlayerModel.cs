using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Game.Shared.Models.Requests
{
    public class ConnectPlayerModel
    {
        [Required]
        public long SessionId { get; set; }
        [Required]
        public long PlayerId { get; set; }
    }
}
