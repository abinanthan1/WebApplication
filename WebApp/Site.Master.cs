using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
	public partial class SiteMaster : MasterPage
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{

				if (Session["role"] != null && Session["role"].ToString() == "user" && Session["Username"] != null)
					{
						Linkbutton.Visible = false; // login
						Linkbutton1.Visible = false; // sign in
						Linkbutton2.Visible = true; // logout
						Linkbutton3.Visible = true; // hello user
						Linkbutton3.Text = "Welcome  " + Session["Username"].ToString();
					}
				


			}
			catch { }
		

		}

        protected void Linkbutton_Click(object sender, EventArgs e)
        {
			Response.Redirect("Login.aspx");
        }

		protected void Linkbutton1_Click(object sender, EventArgs e)
		{
			Response.Redirect("Register.aspx");
		}

		protected void Linkbutton2_Click(object sender, EventArgs e)
		{
			Session["Username"] = "";
			Session["role"] = "";
		
			if (Session["role"].Equals(""))
			{
				Linkbutton.Visible = true;//login
				Linkbutton1.Visible = true;//sign in
				Linkbutton2.Visible = false;//logout
				Linkbutton3.Visible = false;//hello user
			}
		}
	}
}