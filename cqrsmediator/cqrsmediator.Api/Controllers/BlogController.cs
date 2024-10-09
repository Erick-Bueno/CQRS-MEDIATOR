namespace Name.Controllers
{
    using cqrsmediator.Domain.Entity;
    using cqrsmediator.Domain.Models;
    using cqrsmediator.Domain.ObjectValues;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post(BlogDto blogDto)
        {
            var blog = Blog.Create(new Email(blogDto.Email));
            return Ok();
        }
    }
}