using System;
using System.Collections.Generic;


namespace PShop.Models.DBEntities
{
    public class Sports
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<Teams> Teams { get; set; } = new List<Teams>();
       
    }
}
