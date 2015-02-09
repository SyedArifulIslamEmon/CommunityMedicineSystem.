using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityMedicineSystem.DAL;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.BLL
{
    public class DistrictManager
    {
        private DistrictGateway aDistrictGateway = new DistrictGateway();
        public List<District> GetAll()
        {
            return aDistrictGateway.GetDistricts();
        }

        public District Find(string name)
        {
            return aDistrictGateway.Find(name);
        }
    }
}
