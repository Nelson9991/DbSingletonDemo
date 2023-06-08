using Microsoft.Data.SqlClient;

namespace DbSingletonDemo;

public class DbConectionProvider
{
  public static SqlConnection GetConnection =  new SqlConnection("Server=.;Database=MplusDb;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;");
  
  private DbConectionProvider() { }
}