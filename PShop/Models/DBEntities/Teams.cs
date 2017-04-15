using System;
using System.Collections.Generic;

namespace PShop.Models.DBEntities
{
    public class Teams
    {
        public Guid Id { get; set; }
        public string TeamName { get; set; }
        public Guid SportId { get; set; }
        public Sports Sport { get; set; }
        public List<Players> Players { get; set; } = new List<Players>();
               

    }
}
