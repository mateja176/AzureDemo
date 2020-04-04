using System;
using System.Collections.Generic;
using System.Linq;
using AzureDemo.DbContexts;
using AzureDemo.Entities;

namespace AzureDemo.Services
{
  public class BloggingRepository : IBloggingRepository
  {
    private readonly BloggingContext _context;

    public BloggingRepository(BloggingContext context)
    {
      _context = context;
    }

    public IEnumerable<Blog> GetBlogs()
    {
      return _context.Blogs.ToList<Blog>();
    }

    public IEnumerable<Post> GetPosts(Guid blogId)
    {
      if (blogId == Guid.Empty)
      {
        throw new ArgumentNullException(nameof(blogId));
      }

      return _context.Posts
          .Where(b => b.BlogId == blogId)
          .OrderBy(b => b.Title).ToList();
    }
  }
}
