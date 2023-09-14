using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
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
				SqlCommand cmd = new SqlCommand("select * from Userdetail where Username = '" + TextBox1.Text.Trim() + "' and Password = '" + TextBox2.Text.Trim() + "'", con);
				SqlDataReader dr = cmd.ExecuteReader();
				if (dr.HasRows)
				{
					while(dr.Read())
						{
						Response.Write("<script>alert('Login Successful');</script>");
						Session["Username"] = dr.GetValue(0).ToString();
						Session["Password"] = dr.GetValue(1).ToString();
						Session["role"] = "user";
						Session["status"] = dr.GetValue(5).ToString();
						
					}
					Response.Redirect("home.aspx");
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