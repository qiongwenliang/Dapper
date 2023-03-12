using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DapperTutorialInfrasturcture.Data
{
    public class DapperDbContext
    {
        IDbConnection dbConnection;

        public DapperDbContext()
        {
            dbConnection = new SqlConnection("Data Source=caterpillar902;Initial Catalog=DapperTutorialAntra;Integrated Security=True;TrustServerCertificate=True");   
            //with this, we are connecting to database
        }

        public IDbConnection GetConnection()
        {
            return dbConnection;
        }
    }
}
