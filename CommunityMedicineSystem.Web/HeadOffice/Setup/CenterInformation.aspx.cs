using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.Web.HeadOffice.Setup
{
    public partial class CenterInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                nameLabel.Text = Request.QueryString["name"];
                codeLabel.Text = Request.QueryString["code"];
                passwordLabel.Text = Request.QueryString["password"];
            }

        }
    }
}