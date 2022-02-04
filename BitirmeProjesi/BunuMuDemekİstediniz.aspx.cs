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
    public partial class BunuMuDemekİstediniz : System.Web.UI.Page
    {
        SqlConnection connection = Default.connection;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAra_Click(object sender, EventArgs e)
        {
                AramaYap(txtAra.Text.Trim());
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
                if (dt.Rows.Count > 0)
                {
                    lblOneri.Text = "";
                    rpListe.DataSource = dt;
                    rpListe.DataBind();
                }
                else
                {
                    BunuMuDemekIstediniz(kelime);
                    rpListe.DataSource = null;
                    rpListe.DataBind();
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
                if (dt!=null && dt.Rows.Count > 0)
                {
                    lblOneri.Text = "";
                    lblOneri.Text = string.Format("Bunu mu demek istediniz:<a href=#> <u>{0}</u></a>", dt.Rows[0]["baslik"].ToString());
                }
                else
                {
                    lblOneri.Text = "Aramanıza uygun sonuç bulunamadı.";
                }
            }
        }
    }
