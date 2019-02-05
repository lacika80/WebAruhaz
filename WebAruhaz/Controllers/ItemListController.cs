using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAruhaz.Controllers
{
    public class ItemListController : Controller
    {
        // Models.DB.ContRepo db = new Models.DB.ContRepo();
        // GET: ItemList
        public ActionResult Index()
        {
            Models.WebShopContext ctx = new Models.WebShopContext();
            List<Models.Product> p = ctx.Products.ToList();
            Models.ProductPictureCategory ppc = new Models.ProductPictureCategory(p);
            //Models.DB.Filler f = new Models.DB.Filler();
            //f.alma(db);
            //f.kepek(db);
            return View(/*ctx.Products.ToList()*/ppc);
        }
        public ActionResult Item(int ProdID)
        {
            Models.WebShopContext ctx = new Models.WebShopContext();
            List<Models.Product> p = ctx.Products.Where(o => o.ProdID == ProdID).ToList();
            Models.ProductPictureCategory ppc = new Models.ProductPictureCategory(p);
            return View(ppc);
        }
    }
}