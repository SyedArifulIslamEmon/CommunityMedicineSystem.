using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.DAL
{
    public class ThanaGateway:Gateway
    {
        public List<Thana> GetThanas(int districtId)
        {
            List<Thana> thanaList = new List<Thana>();
            string query = "SELECT * FROM tbl_thanas WHERE district_id=" + districtId;
            DbSqlConnection = new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand = new SqlCommand(query, DbSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();
            while (DbSqlDataReader.Read())
            {
                Thana aThana = new Thana();
                aThana.Id = Convert.ToInt32(DbSqlDataReader["id"]);
                aThana.Name = DbSqlDataReader["name"].ToString();
                aThana.DistrictId = Convert.ToInt32(DbSqlDataReader["district_id"]);
                thanaList.Add(aThana);
            }
            DbSqlDataReader.Close();
            DbSqlConnection.Close();
            return thanaList;
        }
    }
}
