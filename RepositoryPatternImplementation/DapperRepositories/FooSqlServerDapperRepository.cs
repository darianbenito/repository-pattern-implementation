using System;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using RepositoryPatternImplementation.Contracts;
using RepositoryPatternImplementation.Contracts.SqlEngineSpecifications;
using RepositoryPatternImplementation.Entities;

// ReSharper disable RedundantAnonymousTypePropertyName
// ReSharper disable RedundantTernaryExpression

namespace RepositoryPatternImplementation.DapperRepositories
{
    public class FooSqlServerDapperRepository : SqlServerDapperRepository<Foo>, IFooRepository
    {
        public FooSqlServerDapperRepository(ISqlServerEngineSpecifications sqlEngineSpecifications) : base(sqlEngineSpecifications)
        {
        }

        public Foo GetByName(string name)
        {
            Foo fooToReturn;

            using (var cn = SqlServerEngineSpecifications.CreateAndOpenConnection())
            {
                const string getByNameQuery = "select m.Id, m.Name " +
                                               "where m.Name = @Name;";

                var getByNameParams = new { Name = name };

                fooToReturn = cn.Query<Foo>(getByNameQuery, getByNameParams)
                                    .FirstOrDefault();
            }

            return fooToReturn;
        }

        public async Task<Foo> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}