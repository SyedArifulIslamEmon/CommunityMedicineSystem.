using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;
using CommunityMedicineSystem.BLL;
using CommunityMedicineSystem.DAO;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using Newtonsoft.Json;

namespace CommunityMedicineSystem.Web.Centers
{
    public partial class PatientRegistration : Page
    {
        private PatientInfoManager aPatientInfoManager=new PatientInfoManager();
        private DoctorManager aDoctorManager=new DoctorManager();
        private DiseaseManager aDiseaseManager=new DiseaseManager();
        private MedicineManager aMedicineManager=new MedicineManager();
        private PatientManager aPatientManager=new PatientManager();
        private DistrictManager aDistrictManager=new DistrictManager();
        private TreatmentManager aTreatmentManager=new TreatmentManager();
        private MedicineStockManager aMedicineStockManager=new MedicineStockManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"].ToString() == "user")
                    Response.Redirect("../Login/Login.aspx");
                else
                {
                    LoadDoctorDropDownList();
                    LoadDiseaseDropDownList();
                    LoadMedicineDropDownList();
                    errorlabel.Visible = false;
                }
            }
        }

        private void LoadMedicineDropDownList()
        {
            medicinedropDownList.DataSource = aMedicineStockManager.GetAllStock((int) Session["centerId"]);
            medicinedropDownList.DataTextField = "MedicineName";
            medicinedropDownList.DataBind();
        }

        private void LoadDiseaseDropDownList()
        {
            diseaseDropDownList.DataSource = aDiseaseManager.GetAll();
            diseaseDropDownList.DataTextField = "Name";
            diseaseDropDownList.DataBind();
        }

        private void LoadDoctorDropDownList()
        {
            doctorDropDownList.DataSource = aDoctorManager.GetDoctorsByCenter((int) Session["centerId"]);
            doctorDropDownList.DataTextField = "Name";
            doctorDropDownList.DataValueField = "Id";
            doctorDropDownList.DataBind();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            var disease = diseases.Value.Split(',');
            var medicine = medicines.Value.Split(',');
            var dose = doses.Value.Split(',');
            var doseRule = meals.Value.Split(',');
            var quantity = quantities.Value.Split(',');
            var note = notes.Value.Split(',');
            var date = dateTextBox.Value;
            var doctorId = Convert.ToInt32(doctorDropDownList.SelectedValue);
            var observation = observationTextBox.Text;
            string[] districtName = addressTextBox.Text.Split(' ');
            diseases.Value = medicines.Value = doses.Value = meals.Value = quantities.Value = notes.Value = "";
            Patient aPatient = new Patient()
            {
                VoterId = voterIdTextBox.Text,
                DistrictId = aDistrictManager.Find(districtName[districtName.Length-1]).Id
            };
            aPatientManager.Save(aPatient);
            int serviceId = aPatientManager.GetLastServiceTakenId();
            for (int i = 0; i < medicine.Length-1; i++)
            {
                Treatment aTreatment = new Treatment()
                {
                    Observation = observation,
                    Date = Convert.ToDateTime(date),
                    DoctorId = doctorId,
                    DiseaseId = aDiseaseManager.Find(disease[i]).Id,
                    MedicineId = aMedicineManager.Find(medicine[i]).Id,
                    Dose = dose[i],
                    Quantity = Convert.ToInt32(quantity[i]),
                    Note = note[i],
                    DoseRules = doseRule[i],
                    CenterId = Convert.ToInt32(Session["centerId"]),
                    ServiceTakenId = serviceId
                };
                aTreatmentManager.Save(aTreatment);
            }
            
        }

        protected void showDetailsButton_Click(object sender, EventArgs e)
        {
            errorlabel.Visible = false;
            string message = "";
            try
            {
                Voter aVoter = aPatientInfoManager.GetPatientInfo(voterIdTextBox.Text);
                if (aVoter != null)
                {
                    nameTextBox.Text = aVoter.name;
                    addressTextBox.Text = aVoter.address;
                    ageTextBox.Text = ((DateTime.Today - DateTime.Parse(aVoter.date_of_birth)).Days/365).ToString();
                    serviceGivenTextBox.Text = aPatientManager.GetTotalNoOfServiceTaken(aVoter.id).ToString();
                }
                else
                    message = "Wrong Voter Id.";
            }
            catch (FormatException)
            {
                message = "Invalid input.";
            }
            if (message != "")
            {
                errorlabel.Visible = true;
                errorlabel.InnerText = message;
            }
        }

        protected void showHistoryButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../HistoryOfPatient.aspx?action=center&voterId="+voterIdTextBox.Text);
        }
    }
}