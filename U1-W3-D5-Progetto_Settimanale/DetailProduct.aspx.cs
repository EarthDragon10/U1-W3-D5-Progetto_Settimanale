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
                }
            }
        }
    }
}