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
    public class MedicineStockManager
    {
        MedicineStockGateway aMedicineStockGateway=new MedicineStockGateway();
        public void SendMedicineToCenter(MedicineStock aMedicineStock)
        {
            if (aMedicineStockGateway.Find(aMedicineStock) != null)
                aMedicineStockGateway.IncreaseMedicineQuantity(aMedicineStock);
            else
                aMedicineStockGateway.SendMedicineToCenter(aMedicineStock);
        }

        public void SendMedicineToCenter(List<MedicineStock> medicineStocks)
        {
            foreach (MedicineStock aMedicineStock in medicineStocks)
            {
                SendMedicineToCenter(aMedicineStock);
            }
        }
        public List<MedicineStockReport> GetAllStock(int centerId)
        {
            return aMedicineStockGateway.GetAllStock(centerId);
        }
    }
}
