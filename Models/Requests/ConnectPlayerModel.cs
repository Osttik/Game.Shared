using Game.Shared.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Game.Shared.Models.Requests
{
    public class ConnectPlayerModel
    {
        [Required]
        public required long SessionId { get; set; }
        [Required]
        public required long PlayerId { get; set; }
    }
}
