using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDownAssignment1
{
    public partial class DropDownPrj1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


                string[] str = new string[] { "Select", "Jeep", "Mercedes", "BMW", "Bugatti" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/images/" + str + ".jpg";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "Jeep")
            {
                TextBox1.Text = "17.79 Lakhs";
            }
            else if (DropDownList1.SelectedValue == "Mercedes")
            {
                TextBox1.Text = "50 Lakhs";
            }
            else if (DropDownList1.SelectedValue == "BMW")
            {
                TextBox1.Text = "1 cr";
            }
            else if (DropDownList1.SelectedValue == "Bugatti")
            {
                TextBox1.Text = "19 cr";
            }
        }
    }
}