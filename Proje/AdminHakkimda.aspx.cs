﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityCore
{
    public partial class AdminHakkimda1 : System.Web.UI.Page
    {
        DbCvEntityCoreEntities db = new DbCvEntityCoreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TblHakkimda.ToList();
            Repeater1.DataBind();
        }
    }
}