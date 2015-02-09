using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityMedicineSystem.DAL;
using CommunityMedicineSystem.DAO;
using CommunityMedicineSystem.DAO.ViewModel;

namespace CommunityMedicineSystem.BLL
{
    public class PatientManager
    {
       private PatientGateway aPatientGateway=new PatientGateway();
        private  TreatmentManager aTreatmentManager=new TreatmentManager();
        public void Save(Patient aPatient)
        {
            aPatientGateway.Save(aPatient);
        }

        public Patient Find(string voterId)
        {
            return aPatientGateway.Find(voterId);
        }

        public int GetLastServiceTakenId()
        {
            return aPatientGateway.GetLastServiceTakenId();
        }

        public int GetTotalNoOfServiceTaken(string voterId)
        {
            return aPatientGateway.GetTotalServiceTaken(voterId);
        }

        public List<PatientHistory> GetPatientHistoryList(string voterId)
        {
            return aPatientGateway.GetAllHistory(voterId);
        }
    }
}
