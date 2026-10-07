using System.Data;
using Microsoft.Extensions.Configuration;

namespace BlazorSample.DAL
{
    public class VTPAUsers
    {
        private readonly string _connectionString;

        public VTPAUsers(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Missing ConnectionStrings:DefaultConnection");
        }
        public DataTable GetAllVTPAUsers()
        {
            string query = "SELECT * FROM VTPAUsers";
            return DBUtils.GetQueryDataTable(_connectionString, query);
        }

        public DataTable GetOneUserByName(string userName)
        {
            string query = $"SELECT * FROM VTPAUsers WHERE UserName = '{userName}'";
            return DBUtils.GetQueryDataTable(_connectionString, query);
        }
    }
}