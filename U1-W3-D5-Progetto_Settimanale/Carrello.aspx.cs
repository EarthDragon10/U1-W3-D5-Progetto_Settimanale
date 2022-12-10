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
            Repeater_Cart.DataSource = Products.cardOfProducts; 
            Repeater_Cart.DataBind();
        }
    }
}