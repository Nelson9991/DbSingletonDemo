namespace DbSingletonDemo.Test;

public class SingletonDbConnectionTest
{
  [Fact]
  public void DbConnectionPorvider_should_return_the_same_SqlConnection_instance()
  {
    var dbConnection1 = DbConectionProvider.GetConnection;
    var dbConnection2 = DbConectionProvider.GetConnection;
    
    Assert.Same(dbConnection1, dbConnection2);
  }
}