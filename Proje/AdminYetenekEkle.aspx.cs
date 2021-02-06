using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityCore
{
    public partial class AdminYetenekEkle : System.Web.UI.Page
    {
        DbCvEntityCoreEntities db = new DbCvEntityCoreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnYetenekEkle_Click(object sender, EventArgs e)
        {
            TblYetenekler yaz = new TblYetenekler();
            yaz.Yetenek = TxtYetenek.Text;
            db.TblYetenekler.Add(yaz);
            db.SaveChanges();
            Response.Redirect("AdminYeteneklerim.aspx");
        }
    }
}