using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admins : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AdminProperties ap = new AdminProperties();
        AdminMethods am = new AdminMethods();
        ap=am.GetAllAdmin();
        admin.DataSource = ap.GetAllAdmin;
        admin.DataBind();
    }

}
