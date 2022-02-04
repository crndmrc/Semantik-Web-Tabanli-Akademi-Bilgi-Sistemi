using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace BitirmeProjesi
{
    public partial class Sonuclar : System.Web.UI.Page
    {
        SqlConnection connection = Default.connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            string aranan = Request.QueryString["arananKelime"].ToString();
                SqlDataAdapter adp = new SqlDataAdapter("Select baslik,yazari,tarihi from Makale " +
                    "where baslik " + "like '%" + aranan + "%'", connection);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                rptAramaSonuclari.DataSource = dt;
                rptAramaSonuclari.DataBind();
           
        }

        protected void btnArama_Click1(object sender, EventArgs e)
        {
                AramaYap(txtArama1.Text.Trim());
        }
        void AramaYap(string kelime)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from Makale where baslik like '%'+ @kelime+'%'", connection);

            cmd.Parameters.AddWithValue("@kelime", kelime);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Load(dr);
            if (dt != null && dt.Rows.Count > 0)
            {
                lblOneri.Text = "";
                rptAramaSonuclari.DataSource = dt;
                rptAramaSonuclari.DataBind();
            }
            else
            {
                BunuMuDemekIstediniz(kelime);
                rptAramaSonuclari.DataSource = null;
                rptAramaSonuclari.DataBind();
            }
            connection.Close();
        }
        void BunuMuDemekIstediniz(string kelime)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            SqlCommand cmd = new SqlCommand("select top 1 * from Makale where Difference(baslik,@Kelime)>=3", connection);
            cmd.Parameters.AddWithValue("@Kelime", kelime);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Load(dr);
            if (dt != null && dt.Rows.Count > 0)
            {
                lblOneri.Text = "";
                lblOneri.Text = string.Format("Bunu mu demek istediniz:<a href=#> <u>{0}</u></a>", dt.Rows[0]["baslik"].ToString());
            }
            else
            {
                lblOneri.Text = "Aramanıza uygun sonuç bulunamadı.";
                string aranan = Request.QueryString["arananKelime"].ToString();
                    SqlDataAdapter adp = new SqlDataAdapter("Select baslik,yazari,tarihi from Makale " +
                        "where baslik " + "like '%" + aranan + "%'", connection);
                    DataTable dt1 = new DataTable();
                    adp.Fill(dt1);
                    rptAramaSonuclari.DataSource = dt;
                    rptAramaSonuclari.DataBind();
            }
        }
        protected void rptAramaSonuclari_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}