using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAruhaz.Models.DB
{
    public class ItemPicture
    {
        public static readonly string path = "~/Content/Images/";
        [Key]
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Name { get; set; }
        [ForeignKey("ItemId")]
        public virtual Item Item { get; set; }
    }
}