using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CommunityMedicineSystem.DAO;
using Newtonsoft.Json;

namespace CommunityMedicineSystem.BLL
{
    public class PatientInfoManager
    {
        public Voter GetPatientInfo(string voterId)
        {
            string url = "http://nerdcastlebd.com/web_service/voterdb/index.php/voters/voter/" + voterId;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(url);
            string jsonData = JsonConvert.SerializeXmlNode(xmlDoc);
            if (!string.IsNullOrEmpty(jsonData))
            {
                PatientInfo aPatientInfo = JsonConvert.DeserializeObject<PatientInfo>(jsonData);
                return aPatientInfo.xml.voter;
            }
            return null;
        }
    }
}
