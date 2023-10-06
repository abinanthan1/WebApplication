using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebApp
{
	public partial class WebForm3 : System.Web.UI.Page
	{
		string strcon = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;

		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{
				if (!IsPostBack)
				{

					BindGrid();
					if (Session["role"] == null)
					{
						Response.Redirect("Login.aspx");
					}
					
				}
			}
			catch (Exception a)
			{
				Response.Write
					(a.Message);	
			}
			
		}

		private void BindGrid()
		{
			using (SqlConnection con = new SqlConnection(strcon))
			{
				try
				{
					con.Open();
					SqlCommand cmd = new SqlCommand("SELECT PersonID, Firstname, Email, City FROM Personaldata", con);
					SqlDataAdapter ada = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					ada.Fill(dt);

	
					Gridview1.DataSource = dt;
					Gridview1.DataBind();


					ViewState["dirstate"] = dt;
					ViewState["sortdr"] = "Asc";

					con.Close();
				}
				catch (Exception ex)
				{
					Response.Write("An error occurred: " + ex.Message);
				}
			}
		}

		protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
		{
			Gridview1.PageIndex = e.NewPageIndex;
			BindGrid();
		}

		protected void Gridview1_Sorting(object sender, GridViewSortEventArgs e)
		{
			DataTable dt = (DataTable)ViewState["dirstate"];

			if (dt != null)
			{
				string sortDirection = ViewState["sortdr"].ToString();

				if (sortDirection == "Desc")
				{
					dt.DefaultView.Sort = e.SortExpression + " ASC";
					ViewState["sortdr"] = "Asc";

				}
				else
				{
					dt.DefaultView.Sort = e.SortExpression + " DESC";
					ViewState["sortdr"] = "Desc";
				}


				Gridview1.DataSource = dt;
				Gridview1.DataBind();
			}
		}
	}
}
