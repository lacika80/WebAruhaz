using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAruhaz.Models.DB
{
    public class ContRepo : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item_Cat_Connector> Item_Cat_Connectors { get; set; }
        public DbSet<ItemPicture> ItemPictures { get; set; }
    }
}