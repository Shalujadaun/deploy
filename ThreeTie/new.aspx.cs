using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThreeTie
{
    public partial class _new : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Output;
            BusinessObject obb = new BusinessObject();
            BusinessLayer obbb = new BusinessLayer();

            obb.userID = txuserid.Text;
            obb.password = txpassword.Text;

            Output = obbb.LoginUserDetails(obb);

        }
    }
}