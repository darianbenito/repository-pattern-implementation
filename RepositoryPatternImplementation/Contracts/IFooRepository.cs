using System.Threading.Tasks;
using RepositoryPatternImplementation.Entities;

namespace RepositoryPatternImplementation.Contracts
{
    public interface IFooRepository : IRepository<Foo>
    {
        Foo GetByName(string name);

        Task<Foo> GetByNameAsync(string name);
    }
}
