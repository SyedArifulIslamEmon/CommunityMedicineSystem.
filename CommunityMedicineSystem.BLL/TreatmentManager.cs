using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityMedicineSystem.DAL;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.BLL
{
    public class TreatmentManager
    {
        private TreatmentGateway aTreatmentGateway=new TreatmentGateway();
        public void Save(Treatment aTreatment)
        {
            aTreatmentGateway.Save(aTreatment);
        }
    }
}
