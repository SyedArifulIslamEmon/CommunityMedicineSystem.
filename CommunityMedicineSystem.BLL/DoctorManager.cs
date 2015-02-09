using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityMedicineSystem.DAL;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.BLL
{
    public class DoctorManager
    {
        private DoctorGateway aDoctorGateway=new DoctorGateway();
        public string Save(Doctor aDoctor)
        {
            aDoctorGateway.Save(aDoctor);
            return "Saved";
        }

        public List<Doctor> GetDoctorsByCenter(int centerId)
        {
            return aDoctorGateway.GetDoctorsByCenter(centerId);
        }
    }
}
