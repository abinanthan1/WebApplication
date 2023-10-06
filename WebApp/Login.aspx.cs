using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using Label = System.Reflection.Emit.Label;

namespace WebApp
{

	public partial class WebForm1 : System.Web.UI.Page
	{
		string strcon = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;

		protected void Page_Load(object sender, EventArgs e)
		{
			


		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection con = new SqlConnection(strcon);
				con.Open();
				SqlCommand cmd = new SqlCommand("Login_pro", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Email", TextBox1.Text.ToString());
				cmd.Parameters.AddWithValue("@Password",TextBox2.Text.ToString());
				int usercount = (Int32)cmd.ExecuteScalar();
				if (usercount == 1) { 
						Response.Write("<script>alert('Login Successful');</script>");
						Session["Username"] =TextBox1;
						Session["role"] = "user";
						Response.Redirect("Home.aspx");
					
					
				}
				else
				{
					Response.Write("<script>alert('Login unsuccessful incorrect password or username');</script>");

				}
				con.Close();
			}
			catch (Exception ex)
			{
				Response.Write(ex.Message);
			}
		}
	}
}