using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_StudenDashboard : System.Web.UI.Page
{
     public string userName = string.Empty;       // Global variable for username
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] != null)
        {
            userName = Session["UserName"].ToString();
        }

    }
}