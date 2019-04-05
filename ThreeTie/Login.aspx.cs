using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThreeTie
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int Output;
            BusinessObject obb = new BusinessObject();
            BusinessLayer obbb = new BusinessLayer();

            obb.userID = txtuserid.Text;
            obb.password = txtpassword.Text;

           Output = obbb.LoginUserDetails(obb);

            Session["userId"] = txtuserid.Text;
            
            if(Output>0)
            {

                Response.Redirect("next.aspx", true);
            }
            else
            {
                lblMessage.Text = "Not Registered User" ;
            }

        }
                
    }
}