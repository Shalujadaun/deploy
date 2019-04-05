using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThreeTie

{

    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string Output = string.Empty;
            BusinessObject obb = new BusinessObject();
            BusinessLayer obbb = new BusinessLayer();


            obb.userID = txtuserid.Text;
            obb.password = txtpassword.Text;

            Output = obbb.AddUserDetails(obb);

           
            lblMessage.Text = "Status = " + Output;

            
         }

         
        
}
}