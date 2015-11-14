using System.Collections.Generic;

namespace Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        ICollection<Person> GetChildren();
    }
}