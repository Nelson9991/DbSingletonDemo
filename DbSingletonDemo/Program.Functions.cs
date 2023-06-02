using DbSingletonDemo;
using Microsoft.Data.SqlClient;

partial class Program
{
  static void ExecuteSqlScript(string tableName, string sqlScript, List<string> columnNames)
  {
    // Obtener la conexión a la base de datos de forma singleton
    var db = DbConectionProvider.GetConnection;

    var command = new SqlCommand(sqlScript, db);

    try
    {
      db.Open();
      var reader = command.ExecuteReader();
      Console.WriteLine($"Datos de la tabla {tableName}");
      while (reader.Read())
      {
        for (var i = 0; i < columnNames.Count; i++)
        {
          Console.WriteLine($"{columnNames[i]}: {reader[i]}");
        }
        Console.WriteLine("====================================\n");
      }
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
      throw;
    }
    finally
    {
      db.Close();
    }
  }
}