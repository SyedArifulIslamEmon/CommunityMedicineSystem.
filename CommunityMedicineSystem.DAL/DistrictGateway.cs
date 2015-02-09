using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.DAL
{
    public class DistrictGateway:Gateway
    {
        public List<District> GetDistricts()
        {
            List<District> districtList = new List<District>();
            string query = "SELECT * FROM tbl_districts";
            DbSqlConnection = new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand = new SqlCommand(query, DbSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();
            while (DbSqlDataReader.Read())
            {
                District aDistrict = new District();
                aDistrict.Id = Convert.ToInt32(DbSqlDataReader["id"]);
                aDistrict.Name = DbSqlDataReader["name"].ToString();
                districtList.Add(aDistrict);
            }
            DbSqlDataReader.Close();
            DbSqlConnection.Close();
            return districtList;
        }

        public District Find(string name)
        {
            string query = "SELECT * FROM tbl_districts WHERE name='" + name + "';";
            DbSqlConnection = new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand = new SqlCommand(query, DbSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();
            District aDistrict = new District();
            DbSqlDataReader.Read();
            aDistrict.Id = Convert.ToInt32(DbSqlDataReader["id"]);
            aDistrict.Name = DbSqlDataReader["name"].ToString();
            DbSqlDataReader.Close();
            DbSqlConnection.Close();
            return aDistrict;
        }
    }
}
