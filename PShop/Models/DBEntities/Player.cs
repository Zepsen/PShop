using System;

namespace PShop.Models.DBEntities
{
    public class Player
    {
        public Guid Id { get; set; }
        public string PlayerName { get; set; }

        public Guid TeamId { get; set; }
    }
}
