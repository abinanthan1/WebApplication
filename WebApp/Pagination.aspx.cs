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
            if (!IsPostBack)
            {
                BindGrid();
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
                    SqlDataAdapter ada = new SqlDataAdapter();
                    {
                        cmd.Connection = con;
                        ada.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        ada.Fill(dt);


                        Gridview1.DataSource = dt;
                        Gridview1.DataBind();
                    }
                }
                catch (Exception ex)
                {

                    Response.Redirect(ex.Message);
                }
            }
        }

        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Gridview1.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void btnPrev_Click(object sender, EventArgs e)
        {
            if (Gridview1.PageIndex > 0)
            {
                Gridview1.PageIndex -= 1;
                BindGrid();
            }
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            if (Gridview1.PageIndex < Gridview1.PageCount - 1)
            {
                Gridview1.PageIndex += 1;
                BindGrid();
            }
        }
    }
}
