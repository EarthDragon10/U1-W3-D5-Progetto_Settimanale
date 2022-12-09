using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U1_W3_D5_Progetto_Settimanale
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RepeaterProduct.DataSource = Products.GetProducts();
            RepeaterProduct.DataBind();
        }

        public class Products
        {
            public int IdProducts { get; set; }
            public string Name { get; set; }

            public string Model { get; set; }

            public string urlImage { get; set; }

            public double Price { get; set; }

            public static List<Products> products = new List<Products>();

            public static List<Products> GetProducts() {
                List<Products> products = new List<Products>();

                Products ball1 = new Products { IdProducts = 1, Name = "Adidas", Model = "Perfomance", urlImage = "~/Img/Products/adidas-Performance.jpg", Price = 11.90 };

                Products ball2 = new Products { IdProducts = 2, Name = "Mondo Toys", Model = "Champions League Format", urlImage = "~/Img/Products/mondo_toys-champions.jpg", Price = 25.90 };

                Products ball3 = new Products { IdProducts = 3, Name = "Nike", Model = "Classic",urlImage = "~/Img/Products/nike-classic.jpg", Price = 19.90 };

                Products ball4 = new Products { IdProducts = 4, Name = "Puma", Model = "Team FINAL", urlImage = "~/Img/Products/Puma_teamFINAL.jpg", Price = 35.90 };

                Products ball5 = new Products { IdProducts = 5, Name = "Senda Rio", Model = "Club Futsal", urlImage = "~/Img/Products/Senda-Rio_Club_Futsal.jpg", Price = 9.90 };

                Products ball6 = new Products { IdProducts = 6, Name = "Zipok", Model = "Champions League Format", urlImage = "~/Img/Products/zipok_champions.jpg", Price = 42.00 };

                products.Add(ball1);
                products.Add(ball2);
                products.Add(ball3);
                products.Add(ball4);
                products.Add(ball5);
                products.Add(ball6);

                return products;
            }
        }
    }
}