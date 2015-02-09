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
    public class MedicineStockGateway:Gateway
    {
        public void SendMedicineToCenter(MedicineStock aMedicineStock)
        {
            SqlQuery = "INSERT INTO tbl_medicines_of_centers VALUES(" + aMedicineStock.CenterId + "," +
                       aMedicineStock.MedicineId + "," + aMedicineStock.Quantity + ");";
            DbSqlConnection=new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand = new SqlCommand(SqlQuery, DbSqlConnection);
            DbSqlCommand.ExecuteNonQuery();
            DbSqlConnection.Close();
        }

        public MedicineStock Find(MedicineStock aMedicineStock)
        {
            SqlQuery = "SELECT * FROM tbl_medicines_of_centers WHERE center_id=" + aMedicineStock.CenterId +
                       " AND medicine_id=" + aMedicineStock.MedicineId + ";";
            DbSqlConnection = new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand = new SqlCommand(SqlQuery, DbSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();
            if (DbSqlDataReader.HasRows)
            {
                MedicineStock aStock = new MedicineStock();
                while (DbSqlDataReader.Read())
                {
                    aStock.Id = Convert.ToInt32(DbSqlDataReader["id"]);
                    aStock.CenterId = Convert.ToInt32(DbSqlDataReader["center_id"]);
                    aStock.MedicineId = Convert.ToInt32(DbSqlDataReader["medicine_id"]);
                    aStock.Quantity = Convert.ToInt32(DbSqlDataReader["quantity"]);
                }
                DbSqlConnection.Close();
                return aStock;
            }
            DbSqlConnection.Close();
            return null;
        }

        public void IncreaseMedicineQuantity(MedicineStock aMedicineStock)
        {
            SqlQuery = "UPDATE tbl_medicines_of_centers SET quantity +=" + aMedicineStock.Quantity + " WHERE center_id=" +
                       aMedicineStock.CenterId + " AND medicine_id=" + aMedicineStock.MedicineId + ";";
            DbSqlConnection = new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand = new SqlCommand(SqlQuery, DbSqlConnection);
            DbSqlCommand.ExecuteNonQuery();
            DbSqlConnection.Close();
        }

        public void DecreaseMedicineQuantity(MedicineStock aMedicineStock)
        {
            SqlQuery = "UPDATE tbl_medicines_of_centers SET quantity -=" + aMedicineStock.Quantity + " WHERE center_id=" +
                       aMedicineStock.CenterId + " AND medicine_id=" + aMedicineStock.MedicineId + ";";
            DbSqlConnection = new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand = new SqlCommand(SqlQuery, DbSqlConnection);
            DbSqlCommand.ExecuteNonQuery();
            DbSqlConnection.Close();
        }
        public List<MedicineStockReport> GetAllStock(int centerId)
        {
            SqlQuery = "SELECT tbl_medicines.name medicinename, tbl_medicines.power as medicinePower,tbl_medicines.type as medicineType, tbl_medicines_of_centers.quantity medicinequantity FROM tbl_medicines JOIN tbl_medicines_of_centers ON tbl_medicines.id=tbl_medicines_of_centers.medicine_id WHERE tbl_medicines_of_centers.center_id='" + centerId + "' ";
            DbSqlConnection = new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand = new SqlCommand(SqlQuery, DbSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();
            List<MedicineStockReport> aMedicineStockReports = new List<MedicineStockReport>();
            while (DbSqlDataReader.Read())
            {
                MedicineStockReport aMedicineStockReport = new MedicineStockReport();
                aMedicineStockReport.MedicineName = DbSqlDataReader["medicinename"] + "," + DbSqlDataReader["medicinePower"] + DbSqlDataReader["medicineType"];
                aMedicineStockReport.MedicineQuantity = Convert.ToInt32(DbSqlDataReader["medicinequantity"]);
                aMedicineStockReports.Add(aMedicineStockReport);
            }
            DbSqlConnection.Close();
            return aMedicineStockReports;
        }
    }
}
