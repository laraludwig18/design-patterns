using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class FactoryMethodExecution
    {
        public static void Execute()
        {
            var sqlCn = DbFactory.Database(DataBase.SqlServer)
                                 .CreateConnector("connectionString")
                                 .Connect();

            sqlCn.ExecuteCommand("select * from sqlTable");
            sqlCn.Close();

            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");

            var oracleCn = DbFactory.Database(DataBase.Oracle)
                                    .CreateConnector("connectionString")
                                    .Connect();

            oracleCn.ExecuteCommand("select * from oracleTable");
            oracleCn.Close();
        }
    }
}