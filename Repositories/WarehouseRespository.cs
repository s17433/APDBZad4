using APBD_04.Model;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace APBD_04.Repositories;

public class WarehouseRespository : IWarehouseRepository
{
    private IConfiguration _configuration;
    private string _connectionString;

    public WarehouseRespository(IConfiguration configuration)
    {
        _configuration = configuration;
        string host = "Pgluch"; // Wprowadź nazwę instancji serwera SQL
        string db = "APBD_04"; // Wprowadź nazwę bazy danych
        string usr = "producty"; // Wprowadź nazwę użytkownika SQL Server
        string pass = "qwe123; // Wprowadź hasło użytkownika SQL Server
        _connectionString = "data source=" + host +
                            ";Persist Security Info=false;database=" + db +
                            ";user id=" + usr + ";password=" +
                            pass +
                            ";Connection Timeout = 0;trustServerCertificate=true;";
    }

    public int AddProductToWarehouse(int IdProduct, int IdWarehouse, int Amount, string CreatedAt)
    {
        using var con = new SqlConnection(_connectionString);

        con.Open();

        using var cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "EXEC AddProductToWarehouse @IdProduct, @IdWarehouse, @Amount, @CreatedAt";
        
        var affectedCount = cmd.ExecuteNonQuery();
        return affectedCount;
    }
}