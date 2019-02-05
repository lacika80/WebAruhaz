using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAruhaz.Models
{
    public class ProductPictureCategory
    {
        public List<Product> Products { get; set; }
        public List<ProductWithphoto> ProductWithphotos { get; set; }
        public List<ProductWithCategory> ProductWithCategories { get; set; }
       // public List<Produc> ProductsPhotos { get; set; }
        /// <summary>
        /// feltölti magát a megadott terméklistának egyéb tulajdonságaival mint kép és tulajdonság
        /// </summary>
        /// <param name="terméklista"></param>
        public ProductPictureCategory(List<Product> products)
        {
            Products = products;
            using (WebShopContext ctx = new WebShopContext())
            {
                List<int> l = new List<int>();
                foreach (Product item in products)
                {
                    l.Add(item.ProdID); 
                }
                ProductWithphotos = ctx.ProductWithphotos.Where(o => l.Contains(o.ProdID)).ToList();
                ProductWithCategories = ctx.ProductWithCategories.Where(o => l.Contains(o.ProdID)).ToList(); 
            }
        }
    }
}