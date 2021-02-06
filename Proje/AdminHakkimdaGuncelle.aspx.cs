using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityCore
{
    public partial class AdminHakkimdaGuncelle : System.Web.UI.Page
    {
        DbCvEntityCoreEntities db = new DbCvEntityCoreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int x = Convert.ToInt32(Request.QueryString["id"]);

                var deger = db.TblHakkimda.Find(x);
                TxtAdSoyad.Text = deger.AdSoyad;
                TxtEgitim.Text = deger.Egitim;
                TxtisDeneyimlerim.Text = deger.isDeneyimlerim;
                TxtiletisimAciklama.Text = deger.iletisimAciklama;
                TxtUnvan.Text = deger.Unvan;
                TxtFoto.Text = deger.Foto;
                db.SaveChanges();
            }
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["id"]);

            var deger = db.TblHakkimda.Find(x);
            deger.AdSoyad = TxtAdSoyad.Text;
            deger.Egitim = TxtEgitim.Text;
            deger.isDeneyimlerim = TxtisDeneyimlerim.Text;
            deger.iletisimAciklama = TxtiletisimAciklama.Text;
            deger.Unvan = TxtUnvan.Text;
            deger.Foto = TxtFoto.Text;
            db.SaveChanges();
            Response.Redirect("AdminHakkimda.aspx");

        }
    }
}