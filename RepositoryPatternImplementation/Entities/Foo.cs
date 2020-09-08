using RepositoryPatternImplementation.Contracts;

namespace RepositoryPatternImplementation.Entities
{
    public class Foo : IEntity
    {
        public long Id { get; set; }

        public string Name { get; set; }
    }
}
