using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommunityMedicineSystem.BLL;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.Web.HeadOffice.Setup
{
    public partial class DiseaseSetup : System.Web.UI.Page
    {

        DiseaseManager aDiseaseManager = new DiseaseManager();
     protected void saveButton_Click(object sender, EventArgs e)
        {
            Disease aDisease = new Disease();
            aDisease.Name = nameTextBox.Text;
            aDisease.Description = descriptionTextBox.Text;
            aDisease.TreatementProcedure = treatementProcedureTextBox.Text;
            aDisease.PreferedMedicine = preferedDrugsTextBox.Text;
            string msg = aDiseaseManager.Save(aDisease);
            messageLabel.Text = msg;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}