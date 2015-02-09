using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityMedicineSystem.DAO
{
    public class Center
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int DistrictId { set; get; }
        public int ThanaId { set; get; }
    }
}
