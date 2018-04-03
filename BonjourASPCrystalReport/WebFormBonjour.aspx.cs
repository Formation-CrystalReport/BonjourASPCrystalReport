using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonjourASPCrystalReport
{
    public partial class WebFormBonjour : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bonjour bonjour = new Bonjour();
            CrystalReportViewer1.ReportSource = null;
            CrystalReportViewer1.ReportSource = bonjour;
            CrystalReportViewer1.DataBind();
        }
    }
}