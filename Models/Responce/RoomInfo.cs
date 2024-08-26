namespace Game.Shared.Models.Responce
{
    public class RoomInfo
    {
        public required long Id { get; set; }
        public required string Name { get; set; }
        public required bool IsPrivate { get; set; }
        public required int PlayersCount { get; set; }
        public required int MaxPlayersCount { get; set; }
    }
}
