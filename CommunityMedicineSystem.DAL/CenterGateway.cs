using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.DAL
{
    public class CenterGateway:Gateway
    {
        public Center Find(string code, string password)
        {
            SqlQuery = "SELECT cen.id,cen.district_id,cen.name,cen.thana_id FROM tbl_center_login log JOIN tbl_centers cen ON log.center_id=cen.id WHERE log.code = '" + code + "' AND log.password= '" + password + "'";
            DbSqlConnection=new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand = new SqlCommand(SqlQuery, DbSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();
            if (DbSqlDataReader.HasRows)
            {
                Center aCenter=new Center();
                while (DbSqlDataReader.Read())
                {
                    aCenter.Id = Convert.ToInt32(DbSqlDataReader["id"]);
                    aCenter.Name = DbSqlDataReader["name"].ToString();
                    aCenter.DistrictId = Convert.ToInt32(DbSqlDataReader["district_id"]);
                    aCenter.ThanaId = Convert.ToInt32(DbSqlDataReader["thana_id"]);
                }
                DbSqlConnection.Close();
                return aCenter;
            }
            DbSqlConnection.Close();
            return null;

        }
        public void Save(Center aCenter)
        {

            SqlQuery = "INSERT INTO tbl_centers VALUES('" + aCenter.Name + "','" + aCenter.DistrictId +
                          "','" + aCenter.ThanaId + "')";
            DbSqlConnection = new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand = new SqlCommand(SqlQuery, DbSqlConnection);
            DbSqlCommand.ExecuteNonQuery();
            DbSqlConnection.Close();

        }

        public Center Find(Center aCenter)
        {
            string query = "SELECT * FROM tbl_centers WHERE name='" + aCenter.Name + "' AND district_id='" + aCenter.DistrictId + "' AND thana_id='" + aCenter.ThanaId + "'";
            DbSqlConnection = new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand = new SqlCommand(query, DbSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();
            if (DbSqlDataReader.HasRows)
            {
                Center center = new Center();
                while (DbSqlDataReader.Read())
                {
                    center.Id = (int)DbSqlDataReader["id"];
                    center.Name = DbSqlDataReader["name"].ToString();
                    center.DistrictId = Convert.ToInt32(DbSqlDataReader["district_id"]);
                    center.ThanaId = Convert.ToInt32(DbSqlDataReader["thana_id"]);
                }
                DbSqlConnection.Close();
                return center;
            }
            DbSqlConnection.Close();
            return null;
        }

        public List<Center> Find(int districtId, int thanaId)
        {
            string query = "SELECT * FROM tbl_centers WHERE district_id=" + districtId + " AND thana_id=" + thanaId +
                           ";";
            DbSqlConnection = new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand = new SqlCommand(query, DbSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();
            List<Center> centers = new List<Center>();
            while (DbSqlDataReader.Read())
            {
                Center aCenter = new Center();
                aCenter.Id = (int) DbSqlDataReader["id"];
                aCenter.Name = DbSqlDataReader["name"].ToString();
                aCenter.DistrictId = Convert.ToInt32(DbSqlDataReader["district_id"]);
                aCenter.ThanaId = Convert.ToInt32(DbSqlDataReader["thana_id"]);
                centers.Add(aCenter);
            }
            DbSqlConnection.Close();
            return centers;
        }

        public void SaveCenterCodeAndPassword(int centerId, string code, string password)
        {
            SqlQuery = "INSERT INTO tbl_center_login VALUES('" + centerId + "','" + code + "','" + password + "')";
            DbSqlConnection = new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand = new SqlCommand(SqlQuery, DbSqlConnection);
            DbSqlCommand.ExecuteNonQuery();
            DbSqlConnection.Close();
        }
    }
}
