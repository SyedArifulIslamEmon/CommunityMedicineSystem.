using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace CommunityMedicineSystem.DAL
{
    public class Gateway
    {
        private static string connectionString =
            WebConfigurationManager.ConnectionStrings["CommunityMedicineSystemDBConnectionString"].ConnectionString;

        public static string ConnectionString
        {
            get { return connectionString; }
        }

        public string SqlQuery { set; get; }

        public SqlConnection DbSqlConnection { set; get; }
        public SqlCommand DbSqlCommand { set; get; }
        public SqlDataReader DbSqlDataReader { set; get; }

    }
}
