using Microsoft.Data.SqlClient;

namespace DbSingletonDemo;

public static class DbConectionProvider
{
  private static readonly SqlConnection _connection = new SqlConnection("Server=.;Database=MplusDb;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;");
  
  public static SqlConnection GetConnection => _connection;
}