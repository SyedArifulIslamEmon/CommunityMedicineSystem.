using System;
using CommunityMedicineSystem.BLL;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.Web.HeadOffice.Setup
{
    public partial class MedicineSetup : System.Web.UI.Page
    {
        private MedicineManager aMedicineManager = new MedicineManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Medicine aMedicine = new Medicine();
            aMedicine.Name = genericNameTextBox.Text;
            aMedicine.Power = powerValueTextBox.Text;
            aMedicine.Type = medicineTypeDropDownList.SelectedValue;
            string message = aMedicineManager.SaveMedicines(aMedicine);
            messageLabel.Text = message;
        }
    }
}