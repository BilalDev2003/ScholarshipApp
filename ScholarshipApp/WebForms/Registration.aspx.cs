using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
	SqlConnection bridge;
	public Registration()
	{
		bridge = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
	}
	protected void Page_Load(object sender, EventArgs e)
	{

	}

	protected void btnSignup_Click(object sender, EventArgs e)
	{
		try
		{
			string userName = txtUsername.Text;
			string eMail = txtEmail.Text;
			string password = txtPassword.Text;
			string mobile = txtMobile.Text;


			string query = @"Insert into UserDetails values(@UserName,@UserEmail,@Password,@UserMobile,@RoleID)";
			SqlCommand command = new SqlCommand(query, bridge);
			command.Parameters.Clear();
			command.Parameters.AddWithValue("@UserName", userName);
			command.Parameters.AddWithValue("@UserEmail", eMail);
			command.Parameters.AddWithValue("@Password", password);
			command.Parameters.AddWithValue("@UserMobile", mobile);
			command.Parameters.AddWithValue("@RoleID", 3);
			if (bridge.State != System.Data.ConnectionState.Open)
				bridge.Open();

			int noofrowseffected = command.ExecuteNonQuery();
			if (noofrowseffected > 0)
			{
				string Title = "Success";
				string Message = "User is registered now";
				ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "Script", "swal('" + Title + "','" + Message + "','success');", true);
				ClearControls();
			}
		}
		catch (Exception ex)
		{
			string Title = "Error";
			string Message = "Something went wrong. Please contact to admin";
			ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "Script", "swal('" + Title + "','" + Message + "','error');", true);

		}

	}

	private void ClearControls()
	{
		txtUsername.Text = string.Empty;
		txtEmail.Text = string.Empty;
		txtPassword.Text = string.Empty;
		txtMobile.Text = string.Empty;
	}
}





