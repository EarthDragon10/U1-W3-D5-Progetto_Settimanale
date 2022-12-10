using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U1_W3_D5_Progetto_Settimanale
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string IdProduct = Request.QueryString["idproduct"];

            foreach (WebForm1.Products item in WebForm1.Products.GetProducts())
            {
                if (item.IdProducts.ToString() == IdProduct)
                {
                    titleProduct.InnerHtml = item.Name;
                    txtModel.InnerHtml = $"Model: {item.Model}";
                    txtPrice.InnerHtml = $"Price: {item.Price}";
                    imgProduct.ImageUrl = item.urlImage;
                    btnAddCart.CommandArgument = item.IdProducts.ToString();
                }
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
           Button btn = (Button)sender;

            int productSelected = Convert.ToInt32(btn.CommandArgument);

            foreach (WebForm1.Products item in WebForm1.Products.GetProducts())
            {
                if(item.IdProducts == productSelected)
                {
                    WebForm1.Products newProduct = new WebForm1.Products
                    {
                        IdProducts = item.IdProducts,
                        Name = item.Name,
                        Model= item.Model,
                        Price = item.Price,
                        urlImage= item.urlImage
                    };

                    WebForm1.Products.cartOfProducts.Add(newProduct);
                }
            }
        }
    }
}