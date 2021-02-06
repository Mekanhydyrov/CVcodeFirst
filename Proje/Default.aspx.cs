using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityCore
{
    public partial class Default : System.Web.UI.Page
    {
        DbCvEntityCoreEntities db = new DbCvEntityCoreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //isim için
            Repeater1.DataSource = db.TblHakkimda.ToList();
            Repeater1.DataBind();

            // Egitim için
            Repeater3.DataSource = db.TblHakkimda.ToList();
            Repeater3.DataBind();

            // iş Deneyimlerim için
            Repeater2.DataSource = db.TblHakkimda.ToList();
            Repeater2.DataBind();

            // Yeteneklerim için
            Repeater4.DataSource = db.TblYetenekler.ToList();
            Repeater4.DataBind();

            // iletişim Açıklama
            Repeater5.DataSource = db.TblHakkimda.ToList();
            Repeater5.DataBind();

            // Hakkımda Açıklama
            Repeater6.DataSource = db.TblHakkimda.ToList();
            Repeater6.DataBind();
        }

        protected void BtnGonder_Click(object sender, EventArgs e)
        {
            // Mesaj Göndermek için
            Tbliletisim yaz = new Tbliletisim();
            yaz.AdSoyad = TxtAd.Text;
            yaz.Mail = TxtMail.Text;
            yaz.Konu = TxtKonu.Text;
            yaz.Mesaj = TxtMesaj.Text;
            db.Tbliletisim.Add(yaz);
            db.SaveChanges();

            // Gönderilen Mesajı Temizlemek için
            TxtAd.Text = "";
            TxtMail.Text = "";
            TxtKonu.Text = "";
            TxtMesaj.Text = "";
        }

        protected void BtnVazgec_Click(object sender, EventArgs e)
        {
            // Mesaj Temizlemek için
            TxtAd.Text = "";
            TxtMail.Text = "";
            TxtKonu.Text = "";
            TxtMesaj.Text = "";
        }
    }
}