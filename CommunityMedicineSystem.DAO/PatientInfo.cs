using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityMedicineSystem.DAO
{
    public class PatientInfo
    {
        public Xml xml { get; set; }
        private Xml2 xml2 { get; set; }
    }

    public class Xml2
    {
        public string version { get; set; }
        public string encoding { get; set; }
    }

    public class Xml
    {
        public Voter voter { get; set; }
    }

    public class Voter
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string date_of_birth { get; set; }
    }

}
