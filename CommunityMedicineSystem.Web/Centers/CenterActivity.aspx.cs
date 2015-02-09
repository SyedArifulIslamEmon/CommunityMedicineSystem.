using System;

namespace CommunityMedicineSystem.Web.Centers
{
    public partial class NewPageUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Session["user"].ToString()=="user")
                    Response.Redirect("../Login/tLogin.aspx");
            }
        }
    }
}