using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CommunityMedicineSystem.BLL;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.Web.HeadOffice
{
    public partial class SendMedicine : System.Web.UI.Page
    {
        private MedicineManager aMedicineManager=new MedicineManager();
        private MedicineStockManager aMedicineStockManager=new MedicineStockManager();
        private DistrictManager aDistrictManager=new DistrictManager();
        private ThanaManager aThanaManager=new ThanaManager();
        private CenterManager aCenterManager=new CenterManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                districtDropDownList.DataSource = aDistrictManager.GetAll();
                districtDropDownList.DataTextField = "Name";
                districtDropDownList.DataValueField = "Id";
                districtDropDownList.DataBind();

                LoadThanaDropDownList();
                LoadCenterdropDownList();

                medicineDropDownList.DataSource = aMedicineManager.GetAll();
                medicineDropDownList.DataBind();
            }
        }
        protected void saveButton_Click(object sender, EventArgs e)
        {
            if (centerDropDownList.Text!=string.Empty)
            {
                List<MedicineStock> medicineStocks = new List<MedicineStock>();
                var medicines = medicineNames.Value.Split(',');
                var quantities = medicineQuantities.Value.Split(',');
                medicineQuantities.Value = "";
                medicineNames.Value = "";
                for (int i = 0; i < medicines.Length - 1; i++)
                {
                    MedicineStock aMedicineStock = new MedicineStock();
                    aMedicineStock.CenterId = Convert.ToInt32(centerDropDownList.SelectedValue);
                    aMedicineStock.MedicineId = aMedicineManager.Find(medicines[i]).Id;
                    aMedicineStock.Quantity = Convert.ToInt32(quantities[i]);
                    medicineStocks.Add(aMedicineStock);
                }
                aMedicineStockManager.SendMedicineToCenter(medicineStocks);
                messageLabel.Text = "Medicines sent successfully.";
            }
        }

        private void LoadThanaDropDownList()
        {
            thanaDropDownList.DataSource = aThanaManager.GetThanasByDistrictId(Convert.ToInt32(districtDropDownList.SelectedValue));
            thanaDropDownList.DataTextField = "Name";
            thanaDropDownList.DataValueField = "Id";
            thanaDropDownList.DataBind();
        }

        protected void districtDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThanaDropDownList();
        }

        private void LoadCenterdropDownList()
        {
            centerDropDownList.DataSource = aCenterManager.Find(Convert.ToInt32(districtDropDownList.SelectedValue),
                Convert.ToInt32(thanaDropDownList.SelectedValue));
            centerDropDownList.DataTextField = "Name";
            centerDropDownList.DataValueField = "Id";
            centerDropDownList.DataBind();
        }

        protected void thanaDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCenterdropDownList();
        }
    }
}