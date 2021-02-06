using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityCore
{
    public partial class AdminYetenekSil : System.Web.UI.Page
    {
        DbCvEntityCoreEntities db = new DbCvEntityCoreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["id"]);

            var deger = db.TblYetenekler.Find(x);
            db.TblYetenekler.Remove(deger);
            db.SaveChanges();
            Response.Redirect("AdminYeteneklerim.aspx");
        }
    }
}