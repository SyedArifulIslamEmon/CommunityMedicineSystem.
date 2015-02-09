using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.DAL
{
    public class TreatmentGateway : Gateway
    {
        private MedicineStockGateway aMedicineStockGateway = new MedicineStockGateway();
        public void Save(Treatment aTreatment)
        {
            SqlQuery = "SELECT quantity FROM tbl_medicines_of_centerS WHERE center_id=" + aTreatment.CenterId +
                       " AND medicine_id=" + aTreatment.MedicineId + ";";
            DbSqlConnection = new SqlConnection(ConnectionString);
            DbSqlConnection.Open();
            DbSqlCommand = new SqlCommand(SqlQuery, DbSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();
            DbSqlDataReader.Read();
            var quantity = (int)DbSqlDataReader["quantity"];
            DbSqlConnection.Close();
            if (quantity >= aTreatment.Quantity)
            {
                SqlQuery = "INSERT INTO tbl_treatments VALUES('" + aTreatment.Observation + "','" + aTreatment.Date +
                           "'," +
                           aTreatment.DoctorId + "," + aTreatment.DiseaseId + "," + aTreatment.MedicineId + ",'" +
                           aTreatment.Dose + "'," + aTreatment.Quantity + ",'" + aTreatment.Note + "','" +
                           aTreatment.DoseRules + "'," + aTreatment.CenterId + "," + aTreatment.ServiceTakenId + ");";
                DbSqlConnection = new SqlConnection(ConnectionString);
                DbSqlConnection.Open();
                DbSqlCommand = new SqlCommand(SqlQuery, DbSqlConnection);
                DbSqlCommand.ExecuteNonQuery();
                DbSqlConnection.Close();
                MedicineStock aMedicineStock = new MedicineStock()
                {
                    CenterId = aTreatment.CenterId,
                    MedicineId = aTreatment.MedicineId,
                    Quantity = aTreatment.Quantity
                };
                aMedicineStockGateway.DecreaseMedicineQuantity(aMedicineStock);
            }
        }
    }
}
