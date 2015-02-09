using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityMedicineSystem.DAL;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.BLL
{
    public class MedicineManager
    {
        private MedicineGateway aMedicineGateway=new MedicineGateway();
        public string SaveMedicines(Medicine aMedicine)
        {
            if (aMedicineGateway.Find(aMedicine.Name) == null)
            {
                aMedicineGateway.Save(aMedicine);
                return "Saved";
            }
            return "Medicine Name must be Unique";
        }

        public Medicine Find(string medicineName)
        {
            return aMedicineGateway.Find(medicineName);
        }
        public List<Medicine> GetAll()
        {
            return aMedicineGateway.GetAll();
        }
    }
}
