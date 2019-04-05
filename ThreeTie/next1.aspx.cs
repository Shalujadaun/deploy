using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThreeTie
{
    public partial class next1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] != null)
            {
                Label1.Text = Session["userid"].ToString();

            }
            else
            {
                Label1.Text = "Sorry,Please enter the value  ";
            }
        }
    }
}