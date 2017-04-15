using PShop.Models.DBEntities;

namespace PShop.Models.ViewModels
{
    public class PlayerViewModel
    {
        public string PlayerName { get; set; }
        public string PlayerTeam { get; set; }
        public string PlayerSport { get; set; }

        public static PlayerViewModel Map(Players player)
        {
            return new PlayerViewModel
            {
                PlayerName = player.PlayerName,
                PlayerTeam = player.Team?.TeamName,
                PlayerSport = player.Team?.Sport?.Title
            };
        }
    }
}
