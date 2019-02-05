using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAruhaz.Models.DB
{
    public class Item_Cat_Connector
    {
        [Key, Column(Order =1)]
        public int CatId { get; set; }
        [Key, Column(Order =2)]
        public int ItemId { get; set; }

        [ForeignKey("ItemId")]
        public virtual Item Item { get; set; }
        [ForeignKey("CatId")]
        public virtual Category Category { get; set; }
    }
}