using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_AdminDashboard : System.Web.UI.Page
{
    public string userName=string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] != null)
        {
             userName = Session["UserName"].ToString();
        }
    }
}