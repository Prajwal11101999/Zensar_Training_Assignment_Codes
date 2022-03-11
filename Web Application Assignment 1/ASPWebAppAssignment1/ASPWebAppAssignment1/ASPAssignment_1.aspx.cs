using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebAppAssignment1
{
    public partial class ASPAssignment_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }
        protected void Submit_click(object sender, EventArgs e)
        {
            Response.Write("Your Registration is Successful.");
            
        }
    }
}