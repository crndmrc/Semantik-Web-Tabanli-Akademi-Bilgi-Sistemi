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
    
    public partial class Default : System.Web.UI.Page
    {
        public static SqlConnection connection = new SqlConnection("Data Source = LAPTOP-KA3PMMLM; " +
            "Initial Catalog=WebSite; Integrated Security=TRUE;");

        protected void btnArama_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Sonuclar.aspx?arananKelime=" + txtArama.Text);
            if (txtArama.Text.Length == 0)
            {
                lblOneri.Text = "En az bir karakter giriniz.";
            }

        }
        
        protected void txtArama_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}