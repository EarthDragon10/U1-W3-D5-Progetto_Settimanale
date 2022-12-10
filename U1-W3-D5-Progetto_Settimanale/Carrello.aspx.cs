using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static U1_W3_D5_Progetto_Settimanale.WebForm1;

namespace U1_W3_D5_Progetto_Settimanale
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Repeater_Cart.DataSource = Products.cartOfProducts;
                Repeater_Cart.DataBind();
            }
            
        }

        protected void Clear_Click(object sender, EventArgs e)
        {

            Products.cartOfProducts.Clear();

            Repeater_Cart.DataSource = Products.cartOfProducts;
            Repeater_Cart.DataBind();
        }
    }
}