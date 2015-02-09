using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.DAL
{
    public class DoctorGateway : Gateway
    {
        public void Save(Doctor aDoctor)
        {
            SqlQuery = "INSERT INTO tbl_doctors VALUES('" + aDoctor.Name + "','" +
                       aDoctor.Degree + "','" + aDoctor.Specialization + "'," + aDoctor.CenterId + ")";
            DbSqlConnection = new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand = new SqlCommand(SqlQuery, DbSqlConnection);
            DbSqlCommand.ExecuteNonQuery();
            DbSqlConnection.Close();
        }

        public List<Doctor> GetDoctorsByCenter(int centerId)
        {
            List<Doctor> doctors = new List<Doctor>();
            SqlQuery = "SELECT * FROM tbl_doctors WHERE center_id=" + centerId + ";";
            DbSqlConnection = new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand = new SqlCommand(SqlQuery, DbSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();
            while (DbSqlDataReader.Read())
            {
                Doctor aDoctor = new Doctor()
                {
                    Id = (int)DbSqlDataReader["id"],
                    Name = DbSqlDataReader["name"].ToString(),
                    CenterId = (int)DbSqlDataReader["center_id"],
                    Degree = DbSqlDataReader["degree"].ToString(),
                    Specialization = DbSqlDataReader["specialization"].ToString()
                };
                doctors.Add(aDoctor);
            }
            DbSqlConnection.Close();
            return doctors;
        }
    }
}
