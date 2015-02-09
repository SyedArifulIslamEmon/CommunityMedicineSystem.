using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommunityMedicineSystem.Web
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["user"] = "user";
                slide();
            }

        }
        protected void slide()
        {
            Random r = new Random();
            int p = r.Next(1, 12);
            slider.ImageUrl = "~/images/medicalBanner" + p + ".jpg";
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            slide();
        }
    }
}