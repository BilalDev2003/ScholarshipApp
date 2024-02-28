using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
	SqlConnection bridge;

	public Login()
	{
		bridge = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
	}
	protected void Page_Load(object sender, EventArgs e)
	{


	}

	protected void btnLogin_Click(object sender, EventArgs e)
	{
		try
		{
			DataTable data = new DataTable();
			string query = @"SELECT * FROM UserDetails WHERE UserEmail=@UserEmail AND Password=@Password";
			SqlCommand command = new SqlCommand(query, bridge);
			command.Parameters.Clear();
			command.Parameters.AddWithValue("@UserEmail", txtUserEmail.Text);
			command.Parameters.AddWithValue("@Password", txtPassword.Text);
			if (bridge.State != System.Data.ConnectionState.Open)
				bridge.Open();

			SqlDataAdapter adapter = new SqlDataAdapter(command);
			adapter.Fill(data);

			if (data.Rows.Count > 0)
			{
				Session["UserName"] = data.Rows[0]["UserName"].ToString();

				string roleID = data.Rows[0]["RoleID"].ToString();
				if (roleID.Equals("1"))
					Response.Redirect("AdminDashboard.aspx");
				else if (roleID.Equals("2"))
					Response.Redirect("ApproverDashboard.aspx");
				else
					Response.Redirect("StudentDashboard.aspx");
			}
			else
			{
				string Title = "Invalid";
				string Message = "Please enter correct credentials";
				ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "Script", "swal('" + Title + "','" + Message + "','warning');", true);
			}

		}
		catch (Exception ex)
		{
			string Title = "Error";
			string Message = "Something went wrong. Please contact to admin";
			ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "Script", "swal('" + Title + "','" + Message + "','error');", true);
		}
	}
}