using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityCore
{
    public partial class Administatistik : System.Web.UI.Page
    {
        DbCvEntityCoreEntities db = new DbCvEntityCoreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TblYetenekler.Count().ToString();
            Label2.Text = db.Tbliletisim.Count().ToString();
            Label3.Text = db.TblYetenekler.Average(p => p.Derece).ToString();
            Label4.Text = db.TblYetenekler.Max(p => p.Derece).ToString();
        }
    }
}