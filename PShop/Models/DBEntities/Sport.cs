using System;
using System.Collections.Generic;


namespace PShop.Models.DBEntities
{
    public class Sport
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public virtual List<Team> Teams { get; set; }
    }
}
