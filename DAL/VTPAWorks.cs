using System.Data;

namespace BlazorSample.DAL
{
    public class VTPAWorks
    {
    private readonly string _connectionString;

    public VTPAWorks(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Missing ConnectionStrings:DefaultConnection");
    }

        public DataTable GetAllVTPAWorks()
        {
            string query = "SELECT * FROM VTPAWorks";
            return DBUtils.GetQueryDataTable(_connectionString, query);
        }
    }
}