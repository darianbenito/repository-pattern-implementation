using System.Data;

namespace RepositoryPatternImplementation.Contracts.SqlEngineSpecifications
{
    public interface ISqlEngineSpecifications
    {
        IDbConnection CreateAndOpenConnection();

        string LastIdentityValueInsertedQuery();
    }
}
