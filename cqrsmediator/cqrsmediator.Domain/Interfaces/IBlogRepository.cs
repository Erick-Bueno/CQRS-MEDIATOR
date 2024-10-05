using cqrsmediator.Domain.Entity;

namespace cqrsmediator.Domain.Interfaces
{
    public interface IBlogRepository
    {
        public Task<List<Blog>> GetAllBlogs();
        public Task<Blog> GetBlogById(int id);
        public Task<Blog> Create (Blog blog);
        public Task<Blog> Update (int id, Blog blog);
        public Task<bool> Delete (Blog blog);
    }
}