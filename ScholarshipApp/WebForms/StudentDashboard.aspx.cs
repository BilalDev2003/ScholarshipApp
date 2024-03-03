using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_StudentDashboard : System.Web.UI.Page
{
    public string userName = string.Empty;       // Global variable for username
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] != null)
        {
            userName = Session["UserName"].ToString();
        }

    }
    protected void btnBox1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ApplyScholarship.aspx");
    }
    protected void btnBox2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ApplyCorrection.aspx");

    }
    protected void btnBox3_Click(object sender, EventArgs e)
    {
        Response.Redirect("TrackExisting.aspx");
    }
    protected void btnBox4_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProfileDetails.aspx");
    }
}