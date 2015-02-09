using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityMedicineSystem.DAL;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.BLL
{
    public class ThanaManager
    {
        private ThanaGateway aThanaGateway = new ThanaGateway();
        public List<Thana> GetThanasByDistrictId(int id)
        {
            return aThanaGateway.GetThanas(id);
        }
    }
}
