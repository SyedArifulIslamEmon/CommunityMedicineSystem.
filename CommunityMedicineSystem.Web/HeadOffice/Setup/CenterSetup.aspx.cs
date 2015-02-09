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
    public partial class CenterSetup : System.Web.UI.Page
    {
        DistrictManager aDistrictManager=new DistrictManager();
        ThanaManager aThanaManager=new ThanaManager();
        CenterManager aCenterManager=new CenterManager(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                districtDropDownList.DataSource = aDistrictManager.GetAll();
                districtDropDownList.DataTextField = "Name";
                districtDropDownList.DataValueField = "Id";
                districtDropDownList.DataBind();
                FillThanaDropDownList(Convert.ToInt32(districtDropDownList.SelectedValue));
            }
        }
        private void FillThanaDropDownList(int districtId)
        {
            thanaDropDownList.DataSource = aThanaManager.GetThanasByDistrictId(districtId);
            thanaDropDownList.DataTextField = "Name";
            thanaDropDownList.DataValueField = "Id";
            thanaDropDownList.DataBind();
        }

        protected void districtDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillThanaDropDownList(Convert.ToInt32(districtDropDownList.SelectedValue));
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Center aCenter = new Center();
            aCenter.Name = nameTextBox.Text;
            aCenter.DistrictId = Convert.ToInt32(districtDropDownList.SelectedValue);
            aCenter.ThanaId = Convert.ToInt32(thanaDropDownList.SelectedValue);
            Center center = aCenterManager.Find(aCenter);

            if (center == null)
            {
                aCenterManager.Save(aCenter);
                string centerCode = aCenterManager.GenerateRandom(6);
                string centerPassword = aCenterManager.GenerateRandom(8);
                Center centerFound = aCenterManager.Find(aCenter);
                aCenterManager.SaveCenterCodeAndPassword(centerFound.Id,centerCode,centerPassword);
                Response.Redirect("CenterInformation.aspx?name="+centerFound.Name+"&code="+centerCode+"&password="+centerPassword);
            }
            else
            {
                messageLabel.Text = "This name already exist.";
            }
        }
    }
}