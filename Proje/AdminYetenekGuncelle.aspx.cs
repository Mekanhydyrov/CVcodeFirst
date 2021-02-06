using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityCore
{
    public partial class AdminYetenekGuncelle : System.Web.UI.Page
    {
        DbCvEntityCoreEntities db = new DbCvEntityCoreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int x = Convert.ToInt32(Request.QueryString["id"]);
                Txtid.Text = x.ToString();

                var deger = db.TblYetenekler.Find(x);
                TxtYetenekGuncelle.Text = deger.Yetenek;
            }         
        }

        protected void BtnYetenekGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["id"]);
            var deger = db.TblYetenekler.Find(x);

            deger.Yetenek = TxtYetenekGuncelle.Text;
            db.SaveChanges();
            Response.Redirect("AdminYeteneklerim.aspx");
        }
    }
}