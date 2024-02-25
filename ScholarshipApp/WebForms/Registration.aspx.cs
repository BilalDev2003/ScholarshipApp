using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
	SqlConnection bridge;
	Resources resources = null;

	public Registration()
	{
		bridge = new SqlConnection("Data Source= DESKTOP-5H6GD9S\\SQLEXPRESS; Initial Catalog= Scholarship;Integrated Security= True");
		resources = new Resources();
	}
	protected void Page_Load(object sender, EventArgs e)
	{

	}

	protected void btnSignup_Click(object sender, EventArgs e)
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

		try
		{
			int noofrowseffected = command.ExecuteNonQuery();
			if (noofrowseffected > 0)
			{
				ClearControls();
				resources.ToastBox(Resources.ToasterMessage.Message(Resources.ToastType.success, "User Saved Succesfully"));
			}
			else
			{
				resources.ToastBox(Resources.ToasterMessage.Message(Resources.ToastType.error, "User not saved"));

			}
		}
		catch (Exception ex)
		{

			resources.ToastBox(Resources.ToasterMessage.Message(Resources.ToastType.error, "User not saved"));
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





