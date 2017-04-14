using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PShop.Models.DBEntities
{
    public class Team
    {
        public Guid Id { get; set; }
        public string TeamName { get; set; }
        public Guid SportId { get; set; }

        public virtual List<Player> Players { get; set; }

    }
}
