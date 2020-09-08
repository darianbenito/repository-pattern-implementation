using RepositoryPatternImplementation.Contracts;
using RepositoryPatternImplementation.Contracts.SqlEngineSpecifications;
using RepositoryPatternImplementation.DapperRepositories;
using RepositoryPatternImplementation.SqlEngineSpecifications;

namespace RepositoryPatternImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO get from config
            const string connectionString = "";

            ISqlServerEngineSpecifications sqlServerEngineSpecifications = new SqlServerEngineSpecifications(connectionString);

            IFooRepository fooRepository = new FooSqlServerDapperRepository(sqlServerEngineSpecifications);
        }
    }
}
