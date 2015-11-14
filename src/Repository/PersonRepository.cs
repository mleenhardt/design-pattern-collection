using System.Collections.Generic;
using System.Data.Entity;

namespace Repository
{
    public class PersonRepository : EntityFrameworkRepository<Person>, IPersonRepository
    {
        public PersonRepository(DbContext dbContext)
            : base(dbContext)
        {
        }

        public ICollection<Person> GetChildren()
        {
            return GetRange(p => p.Age < 10);
        }
    }
}