// Consulta sql
const string sqlScript = """ 
SELECT TOP (1000) [Id],[Code],[Name],[Brand],[Stock]
FROM [MplusDb].[WebMaster].[Equipments] 
""";

// Ejecutar consulta a la Db utilizando la conexion singleton
var columnNamesEquipos = new List<string> { "Id","Codigo", "Nombre", "Marca", "Stock" };
ExecuteSqlScript("Equipos", sqlScript, columnNamesEquipos);

// Ejecutar otra consulta para demostrar que se devuelve la misma instancia de la conexion a la Db
const string sqlScript2 = """ 
SELECT TOP (1000) [Id]
      ,[Name]
      ,[LastName]
      ,[IdCard]
  FROM [MplusDb].[WebMaster].[Technicians]
""";

var columnNamesTecnicos = new List<string> { "Id", "Nombres", "Apellidos", "Cedula" };
ExecuteSqlScript("Tecnicos", sqlScript2, columnNamesTecnicos);

Console.ReadLine();

