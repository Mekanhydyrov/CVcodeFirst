using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityCore
{
    public partial class Login : System.Web.UI.Page
    {

        DbCvEntityCoreEntities db = new DbCvEntityCoreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGiris_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TblAdmin where x.Kullanıci == TxtAd.Text && x.Sifre == TxtSifre.Text select x;
            if (sorgu.Any())
            {
                Response.Redirect("Administatistik.aspx");
            }
            else
            {
                Response.Write("Kullanıcı Adı ya da Şifre Hatalı");
            }
        }
    }
}