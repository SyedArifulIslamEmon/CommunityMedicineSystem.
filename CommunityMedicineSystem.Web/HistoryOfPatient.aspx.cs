using System;
using System.Data;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommunityMedicineSystem.BLL;
using CommunityMedicineSystem.DAO;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
namespace CommunityMedicineSystem.Web
{
    public partial class HistoryOfPatient : System.Web.UI.Page
    {
        private PatientManager aPatientManager=new PatientManager();
        private PatientInfoManager aPatientInfoManager=new PatientInfoManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["action"] == "center")
                {
                    showButton.Visible = false;
                    string voterId = Request.QueryString["voterId"];
                    FillInfoOfVoter(voterId);
                }
                else
                {
                    showButton.Visible = true;
                }

            }
        }

        private void FillInfoOfVoter(string voterId)
        {
            Voter aVoter = aPatientInfoManager.GetPatientInfo(voterId);
            if (aVoter != null)
            {
                voterIdTextBox.Text = aVoter.id;
                addressTextBox.Text = aVoter.address;
                nameTextBox.Text = aVoter.name;
                patientHistoryGridView.DataSource =
                    aPatientManager.GetPatientHistoryList(voterId);
                patientHistoryGridView.DataBind();
            }
                
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            if (voterIdTextBox.Text != string.Empty)
            {
                FillInfoOfVoter(voterIdTextBox.Text);
            }
        }

        protected void pdfButton_Click(object sender, EventArgs e)
        {
        }
    }
}