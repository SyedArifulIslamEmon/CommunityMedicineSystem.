using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityMedicineSystem.DAO;
using CommunityMedicineSystem.DAO.ViewModel;

namespace CommunityMedicineSystem.DAL
{
    public class PatientGateway : Gateway
    {
        public void Save(Patient aPatient)
        {
            int patientId;
            DbSqlConnection = new SqlConnection(ConnectionString);
            Patient patientFound = Find(aPatient.VoterId);
            if (patientFound == null)
            {
                SqlQuery = "INSERT INTO tbl_patients VALUES('" + aPatient.VoterId + "'," + aPatient.DistrictId +
                           ");";
                DbSqlConnection.Open();
                DbSqlCommand = new SqlCommand(SqlQuery, DbSqlConnection);
                DbSqlCommand.ExecuteNonQuery();
                DbSqlConnection.Close();
                SqlQuery = "SELECT MAX(id) FROM tbl_patients;";
                DbSqlConnection.Open();
                DbSqlCommand = new SqlCommand(SqlQuery, DbSqlConnection);
                DbSqlDataReader = DbSqlCommand.ExecuteReader();
                DbSqlDataReader.Read();
                patientId = (int) DbSqlDataReader[0];
                DbSqlConnection.Close();
            }
            else
            {
                patientId = patientFound.Id;
            }
            DbSqlConnection.Open();
            SqlQuery = "INSERT INTO tbl_service_taken VALUES(" + patientId + ");";
            DbSqlCommand = new SqlCommand(SqlQuery, DbSqlConnection);
            DbSqlCommand.ExecuteNonQuery();
            DbSqlConnection.Close();
        }

        public Patient Find(string voterId)
        {
            SqlQuery = "SELECT * FROM tbl_patients WHERE voter_id='" + voterId + "';";
            DbSqlConnection = new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand = new SqlCommand(SqlQuery, DbSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();
            Patient aPatient = new Patient();
            if (DbSqlDataReader.HasRows)
            {
                while (DbSqlDataReader.Read())
                {
                    aPatient.Id = (int)DbSqlDataReader["id"];
                    aPatient.DistrictId = (int)DbSqlDataReader["district_id"];
                    aPatient.VoterId = DbSqlDataReader["voter_id"].ToString();
                }
                DbSqlConnection.Close();
                return aPatient;
            }
            DbSqlConnection.Close();
            return null;
        }

        public int GetLastServiceTakenId()
        {
            SqlQuery = "SELECT MAX(id) FROM tbl_service_taken;";
            DbSqlConnection = new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand = new SqlCommand(SqlQuery, DbSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();
            DbSqlDataReader.Read();
            int serviceTakenId = Convert.ToInt32(DbSqlDataReader[0]);
            DbSqlConnection.Close();
            return serviceTakenId;
        }

        public int GetTotalServiceTaken(string voterId)
        {
            SqlQuery =
                "SELECT COUNT(*) FROM tbl_service_taken ser JOIN tbl_patients pat ON ser.patient_id=pat.id WHERE pat.voter_id='" +
                voterId + "';";
            DbSqlConnection=new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand=new SqlCommand(SqlQuery,DbSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();
            DbSqlDataReader.Read();
            int total = (int) DbSqlDataReader[0];
            DbSqlConnection.Close();
            return total;
        }

        public List<PatientHistory> GetAllHistory(string voterId)
        {
            SqlQuery = "SELECT * FROM view_patient_information WHERE voter_id='" + voterId + "'";
            DbSqlConnection=new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand=new SqlCommand(SqlQuery,DbSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();
            List<PatientHistory> patientHistories=new List<PatientHistory>();
            if (DbSqlDataReader.HasRows)
            {
                while (DbSqlDataReader.Read())
                {
                    PatientHistory aPatientHistory=new PatientHistory();
                    aPatientHistory.VoterId = DbSqlDataReader["voter_id"].ToString();
                    aPatientHistory.Center = DbSqlDataReader["center_name"].ToString();
                    aPatientHistory.Date = Convert.ToDateTime(DbSqlDataReader["date"]);
                    aPatientHistory.Disease = DbSqlDataReader["disease_name"].ToString();
                    aPatientHistory.Doctor = DbSqlDataReader["doctor_name"].ToString();
                    aPatientHistory.Dose = DbSqlDataReader["dose"].ToString();
                    aPatientHistory.Rule = DbSqlDataReader["dose_rules"].ToString();
                    aPatientHistory.Medicine = DbSqlDataReader["medicine_name"] + "," + DbSqlDataReader["power"] +
                                               DbSqlDataReader["type"];
                    aPatientHistory.Observation = DbSqlDataReader["observation"].ToString();
                    aPatientHistory.Quantity = (int)DbSqlDataReader["quantity"];
                    patientHistories.Add(aPatientHistory);
                }
            }
            DbSqlConnection.Close();
            return patientHistories;
        }
    }
}
