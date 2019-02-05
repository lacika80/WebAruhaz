using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAruhaz.Models.DB
{
    public class Filler
    {
        public void alma(ContRepo db)
        {
            var cat1 = new Category();
            cat1.Name = "gyümi";
            db.Categories.Add(cat1);
            db.SaveChanges();

            var cat2 = new Category();
            cat2.Name = "piros";
            db.Categories.Add(cat2);
            db.SaveChanges();

            var cat3 = new Category();
            cat3.Name = "nem piros";
            db.Categories.Add(cat3);
            db.SaveChanges();



            var item = new Item();
            item.IsActive = true;
            item.Name = "alma";
            item.Desc = "piros, finom";
            item.Price = 100;
            item.NumberInWh = 3;
            db.Items.Add(item);
            db.SaveChanges();

            


            var item2 = new Item();
            item2.IsActive = true;
            item2.Name = "banán";
            item2.Desc = "tudod mitől görbe a banán? mert én tudom.";
            item2.Price = 150;
            item2.NumberInWh = 5;
            db.Items.Add(item2);
            db.SaveChanges();

            var item3 = new Item();
            item3.IsActive = true;
            item3.Name = "körte";
            item3.Desc = "nem, nem villanykörte";
            item3.Price = 130;
            db.Items.Add(item3);
            db.SaveChanges();

            var item4 = new Item();
            item4.IsActive = true;
            item4.Name = "szilva";
            item4.Desc = "hull a szilva a fárol, most jöttem a tanyáról";
            item4.Price = 200;
            item4.NumberInWh = 0;
            db.Items.Add(item4);
            db.SaveChanges();

            var item5 = new Item();
            item5.IsActive = true;
            item5.Name = "eper";
            item5.Desc = "jó, igen, tudom. nem most van a szezonja, de hidd el eléggé vegyszerezett, hogy finom és piros legyen.";
            item5.Price = 350;
            item5.NumberInWh = 3;
            db.Items.Add(item5);
            db.SaveChanges();
            Console.WriteLine("alma beirva");

            //var ICC1 = new Item_Cat_Connector();
            //int itemid = db.Database.SqlQuery<int>("select Id from Items where Id='" + 1 + "'").FirstOrDefault();  //item connector teszt: mindig az 1-es itemet kezeli
            //ICC1.ItemId = itemid;
            //ICC1.CatId = (db.Database.SqlQuery<int>("select count(Id) from Items").FirstOrDefault())/2;  // cat id-t automatán beállit, hogy ütközés ne legyen. minden körben +5 item és +3 id, így az itemek fele mindig kisebb lesz mint a kat-ok száma
            //db.Item_Cat_Connectors.Add(ICC1);
            //db.SaveChanges();

            var ICC1 = new Item_Cat_Connector();
            ICC1.ItemId = 1;
            ICC1.CatId = 2;
            db.Item_Cat_Connectors.Add(ICC1);
            db.SaveChanges();

            var ICC2 = new Item_Cat_Connector();
            ICC2.ItemId = 2;
            ICC2.CatId = 3;
            db.Item_Cat_Connectors.Add(ICC2);
            db.SaveChanges();

            var ICC3 = new Item_Cat_Connector();
            ICC3.ItemId = 3;
            ICC3.CatId = 1;
            db.Item_Cat_Connectors.Add(ICC3);
            db.SaveChanges();

            var ICC4 = new Item_Cat_Connector();
            ICC4.ItemId = 4;
            ICC4.CatId = 3;
            db.Item_Cat_Connectors.Add(ICC4);
            db.SaveChanges();

            var ICC5 = new Item_Cat_Connector();
            ICC5.ItemId = 5;
            ICC5.CatId = 2;
            db.Item_Cat_Connectors.Add(ICC5);
            db.SaveChanges();

            var ICC6 = new Item_Cat_Connector();
            ICC6.ItemId = 1;
            ICC6.CatId = 1;
            db.Item_Cat_Connectors.Add(ICC6);
            db.SaveChanges();

            var ICC7 = new Item_Cat_Connector();
            ICC7.ItemId = 5;
            ICC7.CatId = 1;
            db.Item_Cat_Connectors.Add(ICC7);
            db.SaveChanges();


        }
        public void kepek(ContRepo db)
        {
            var kep1 = new ItemPicture();
            kep1.ItemId = 1;
            kep1.Name = "piros-alma.jpg";
            db.ItemPictures.Add(kep1);
            db.SaveChanges();

            var kep2 = new ItemPicture();
            kep2.ItemId = 1;
            kep2.Name = "250px-Apple_logo_black.svg.png";
            db.ItemPictures.Add(kep2);
            db.SaveChanges();

            var kep3 = new ItemPicture();
            kep3.ItemId = 2;
            kep3.Name = "fbe9e3c3e194988ca1a11d0550412d2b_1140x500_c.jpg";
            db.ItemPictures.Add(kep3);
            db.SaveChanges();

            var kep4 = new ItemPicture();
            kep4.ItemId = 3;
            kep4.Name = "korte.jpg";
            db.ItemPictures.Add(kep4);
            db.SaveChanges();

            var kep5 = new ItemPicture();
            kep5.ItemId = 4;
            kep5.Name = "323436_640_6_szilva_forras_scholarly__kitchen.jpg";
            db.ItemPictures.Add(kep5);
            db.SaveChanges();

            var kep6 = new ItemPicture();
            kep6.ItemId = 4;
            kep6.Name = "bolyhos-agyas-szilva-palinka-1-liter-50-xxl.jpeg";
            db.ItemPictures.Add(kep6);
            db.SaveChanges();

            var kep7 = new ItemPicture();
            kep7.ItemId = 5;
            kep7.Name = "116592_eper03-201510171309.jpg";
            db.ItemPictures.Add(kep7);
            db.SaveChanges();


        }
    }
}