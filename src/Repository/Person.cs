namespace Repository
{
    public class Person : IEntity
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; } 
    }
}