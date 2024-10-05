using cqrsmediator.Domain.Entity;
using cqrsmediator.Domain.Interfaces;

namespace cqrsmediator.Infrastructure.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        public Task<Blog> Create(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Task<List<Blog>> GetAllBlogs()
        {
            throw new NotImplementedException();
        }

        public Task<Blog> GetBlogById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Blog> Update(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}