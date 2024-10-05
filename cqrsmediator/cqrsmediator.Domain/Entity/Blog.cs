using cqrsmediator.Domain.Errors;
using OneOf;

namespace cqrsmediator.Domain.Entity
{
    public sealed class Blog : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Author { get; private set; }
        public static OneOf<Blog, Error> Create(string name, string description, string author)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return new InvalidName("Nome invalido");
            }
            if (string.IsNullOrWhiteSpace(author))
            {
                return new InvalidName("Nome de autor invalido");
            }
            return new Blog()
            {
                Id = Guid.NewGuid(),
                Name = name,
                Author = author,
                Description = description
            };
        }
    }
}