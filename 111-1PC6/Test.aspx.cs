using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC6
{
    public partial class Test : System.Web.UI.Page
    {
        string[] school = new string[3] { "台科", "北科", "亞東" };
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int ct = 0; ct < school.Length; ct++)
            {
                ListItem ol = new ListItem();
                ol.Text = school[ct];
                ol.Value = school[ct];
                ddl_Test.Items.Add(ol);
            }
        }
    }
}