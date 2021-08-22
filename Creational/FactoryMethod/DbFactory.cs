using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    // Abstract Creator
    public abstract class DbFactory
    {
        // Factory Method
        public abstract DbConnector CreateConnector(string connectionString);

        public static DbFactory Database(DataBase dataBase) => dataBase switch
        {
            DataBase.SqlServer => new SqlFactory(),
            DataBase.Oracle => new OracleFactory(),
            _ => throw new ApplicationException("Unknown database."),
        };
    }
}