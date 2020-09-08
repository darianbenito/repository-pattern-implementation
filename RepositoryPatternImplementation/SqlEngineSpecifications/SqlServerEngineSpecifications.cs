using System.Data;
using System.Data.SqlClient;
using RepositoryPatternImplementation.Contracts.SqlEngineSpecifications;

namespace RepositoryPatternImplementation.SqlEngineSpecifications
{
    public class SqlServerEngineSpecifications : ISqlServerEngineSpecifications
    {
        private readonly string _connectionString;
        private const string SqlServerLastIdentityValueInsertedQuery = "select CAST(SCOPE_IDENTITY() as bigint);";

        public SqlServerEngineSpecifications(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateAndOpenConnection()
        {
            var sqlConnection = new SqlConnection(_connectionString);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            return sqlConnection;
        }

        public string LastIdentityValueInsertedQuery()
        {
            return SqlServerLastIdentityValueInsertedQuery;
        }
    }
}
