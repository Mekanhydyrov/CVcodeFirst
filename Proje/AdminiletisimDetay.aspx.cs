using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityCore
{
    public partial class AdminiletisimDetay : System.Web.UI.Page
    {
        DbCvEntityCoreEntities db = new DbCvEntityCoreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["id"]);

            var deger = db.Tbliletisim.Find(x);
            TxtAdSoyad.Text = deger.AdSoyad;
            TxtMail.Text = deger.Mail;
            TxtKonu.Text = deger.Konu;
            TxtMesaj.Text = deger.Mesaj;
            db.SaveChanges();
        }
    }
}