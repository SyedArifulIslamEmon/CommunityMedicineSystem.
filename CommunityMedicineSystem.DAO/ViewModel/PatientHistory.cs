using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityMedicineSystem.DAO.ViewModel
{
    public class PatientHistory
    {
        public string VoterId { set; get; }
        public string Center { set; get; }
        public DateTime Date { set; get; }
        public string Doctor { set; get; }
        public string Disease { set; get; }
        public string Observation { set; get; }
        public string Medicine { set; get; }
        public int Quantity { set; get; }
        public string Dose { set; get; }
        public string Rule { set; get; }
    }
}
