namespace cqrsmediator.Domain.Entity
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Author { get; private set; }
    }

}