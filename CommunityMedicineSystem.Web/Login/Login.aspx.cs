using System;
using CommunityMedicineSystem.BLL;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.Web.Login
{
    public partial class Login : System.Web.UI.Page
    {
        CenterManager aCenterManager = new CenterManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void loginButton_Click(object sender, EventArgs e)
        {
            Center aCenter = aCenterManager.Find(codeTextBox.Text, passwordTextBox.Text);
            if (aCenter != null)
            {
                Session["centerId"] = aCenter.Id;
                Session["user"] = "Center";
                Response.Redirect("../Centers/CenterActivity.aspx");
            }
            else
                messageLabel.Text = "Incorrect center code or password";
        }
    }
}