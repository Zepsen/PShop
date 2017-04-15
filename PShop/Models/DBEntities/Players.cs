using System;

namespace PShop.Models.DBEntities
{
    public class Players
    {
        public Guid Id { get; set; }
        public string PlayerName { get; set; }
        public Guid TeamId { get; set; }
        public Teams Team { get; set; }


    }
}
