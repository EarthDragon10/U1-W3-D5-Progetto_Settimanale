using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace U1_W3_D5_Progetto_Settimanale
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            notifyCart.InnerHtml = WebForm1.Products.CartProductLength.ToString();

            //  MARCO, lascio del codice commentato perché, in futuro, vorrei aggiungere le notifiche
            // in tempo reale dei prodotti aggiunti nel carrello

            //if (WebForm1.Products.cartOfProducts.Count > 0)
            //{
            //    CartNotifications.CssClass = "d-flex";
            //    notifyCart.InnerHtml = WebForm1.Products.CartProductLength.ToString();
            //}
            //else
            //{
            //    CartNotifications.CssClass = "d-none";
            //}

        }
    }
}