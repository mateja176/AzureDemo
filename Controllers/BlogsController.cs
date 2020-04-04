using System.Collections.Generic;
using AzureDemo.Entities;
using AzureDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace AzureDemo.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class BlogsController : ControllerBase
  {
    private readonly IBloggingRepository _bloggingRepository;

    public BlogsController(IBloggingRepository bloggingRepository)
    {
      _bloggingRepository = bloggingRepository;
    }

    [HttpGet()]
    public ActionResult<IEnumerable<Blog>> GetBlogs()
    {
      return Ok(_bloggingRepository.GetBlogs());
    }
  }
}
