#nullable disable

namespace Game.Shared.Models.Responce
{
    public class RoomInfo
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsPrivate { get; set; }
        public int PlayersCount { get; set; }
        public int MaxPlayersCount { get; set; }
    }
}
