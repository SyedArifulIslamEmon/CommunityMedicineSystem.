using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityMedicineSystem.DAO
{
    public class Treatment
    {
        public int Id { set; get; }
        public string Observation { set; get; }
        public DateTime Date { set; get; }
        public int DoctorId { set; get; }
        public int DiseaseId { set; get; }
        public int MedicineId { set; get; }
        public string Dose { set; get; }
        public int Quantity { set; get; }
        public string Note { set; get; }
        public string DoseRules { set; get; }
        public int CenterId { set; get; }
        public int ServiceTakenId { set; get; }
    }
}
