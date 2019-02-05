using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAruhaz.Models.DB
{/// <summary>
/// 1 tétel minden szükséges adattal. kategória beállítása Category és Item_Cat_Connector-ban
/// </summary>
    public class Item
    {
        public enum Catenum { cat1, cat2, cat3 }

        [Key]
        public int Id { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public string Name { get; set; }
        public string Desc { get; set; }
        [Required]
        public int Price { get; set; }
        public int? NumberInWh { get; set; }

        public virtual ICollection<Item_Cat_Connector> Item_Cat_Connector { get; set; }
        public virtual ICollection<ItemPicture> ItemPicture { get; set; }

    }
}