using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
	public partial class WebForm2 : System.Web.UI.Page
	{
		String strcon = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			if (Checkmemberexist())
			{
				Response.Write("<script>alert('Member already exist');</script>");
			}
			else
			{
				signUpnewuser();
			}

		}

		bool Checkmemberexist()
		{
			try
			{
				SqlConnection con = new SqlConnection(strcon);
				con.Open();
				SqlCommand cmd = new SqlCommand("select*from Userdetail where Username='" + TextBox1.Text.Trim() + "';", con);
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);
				if (dataTable.Rows.Count >= 1)
				{
					return true;
				}
				else
				{
					return false;
				}
			}

		
		
			catch (Exception ex)
			{
				Response.Write(ex.Message);
				return false;
			}
		}


		void signUpnewuser()
		{


			try
			{
				SqlConnection con = new SqlConnection(strcon);
				con.Open();
				SqlCommand cmd = new SqlCommand("INSERT INTO Userdetail (Username,Password,Email,City,DateOfBirth,Account_status) VALUES(@Username,@Password,@Email,@City,@DateOfBirth,@Account_status)", con);
				cmd.Parameters.AddWithValue("@Username", TextBox1.Text.Trim());
				cmd.Parameters.AddWithValue("@Password", TextBox2.Text.Trim());
				cmd.Parameters.AddWithValue("@Email", TextBox3.Text.Trim());
				cmd.Parameters.AddWithValue("@City", TextBox5.Text.Trim());
				cmd.Parameters.AddWithValue("@DateOfBirth", TextBox4.Text.Trim());
				cmd.Parameters.AddWithValue("@Account_status", "pending");

				cmd.ExecuteNonQuery();
				con.Close();
				Label4.Text = "Registeration successful and now login";
			
				Response.Redirect("Login.aspx");



			}
			catch (Exception ex)
			{
				Response.Write(ex.Message);
			}
		}

	}
}