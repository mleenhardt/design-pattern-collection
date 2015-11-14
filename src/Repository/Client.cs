using System;
using System.Data.Entity;

namespace Repository
{
    public class Client
    {
        public void Run()
        {
            var efRepository = new EntityFrameworkRepository<Person>(new DbContext(String.Empty));
            var allPeople = efRepository.GetAll();

            var personRepository = new PersonRepository(new DbContext(String.Empty));
            var children = personRepository.GetChildren();

            var memoryRepository = new InMemoryRepository<Person>();
            memoryRepository.Add(new Person
            {
                Id = 42,
                Age = 10,
                Name = "Artanis"
            });
        }
    }
}