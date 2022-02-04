using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace BitirmeProjesi
{
    public partial class AramaSonuclari : System.Web.UI.Page
    {
        SqlConnection connection = Default.connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            string detay = Request.QueryString["detay"].ToString();
            SqlDataAdapter adp = new SqlDataAdapter("Select baslik,yazari,tarihi,aciklama from Makale " +
                "where baslik " + "like '%"+detay+"%'",connection);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            rptAramaSonuclari.DataSource = dt;
            rptAramaSonuclari.DataBind();
        }
     
    }
}