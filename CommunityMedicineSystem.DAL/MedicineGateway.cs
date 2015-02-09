using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.DAL
{
    public class MedicineGateway:Gateway
    {
        public void Save(Medicine aMedicine)
        {
            SqlQuery = "INSERT INTO tbl_medicines VALUES('" + aMedicine.Name + "' , '" + aMedicine.Power + "','" + aMedicine.Type + "')";
            DbSqlConnection=new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand = new SqlCommand(SqlQuery, DbSqlConnection);
            DbSqlCommand.ExecuteNonQuery();
            DbSqlConnection.Close();
        }

        public List<Medicine> GetAll()
        {
            SqlQuery = "SELECT * FROM tbl_medicines;";
            DbSqlConnection = new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand = new SqlCommand(SqlQuery, DbSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();
            List<Medicine> medicines=new List<Medicine>();
            while (DbSqlDataReader.Read())
            {
                Medicine aMedicine = new Medicine();
                aMedicine.Name = DbSqlDataReader["name"].ToString();
                aMedicine.Id = Convert.ToInt32(DbSqlDataReader["id"]);
                aMedicine.Power = DbSqlDataReader["power"].ToString();
                aMedicine.Type = DbSqlDataReader["type"].ToString();
                medicines.Add(aMedicine);
            }
            DbSqlConnection.Close();
            return medicines;
        }

        public Medicine Find(string name)
        {
            SqlQuery = "SELECT * FROM tbl_medicines WHERE name='" + name + "'";
            DbSqlConnection=new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand = new SqlCommand(SqlQuery, DbSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();

            if (DbSqlDataReader.HasRows)
            {
                Medicine aMedicine = new Medicine();
                while (DbSqlDataReader.Read())
                {
                    aMedicine.Name = DbSqlDataReader["name"].ToString();
                    aMedicine.Id = Convert.ToInt32(DbSqlDataReader["id"]);
                    aMedicine.Power = DbSqlDataReader["power"].ToString();
                    aMedicine.Type = DbSqlDataReader["type"].ToString();
                }
                DbSqlConnection.Close();
                return aMedicine;
            }
            DbSqlConnection.Close();
            return null;
        }
    }
}
