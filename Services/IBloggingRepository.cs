using System;
using System.Collections.Generic;
using AzureDemo.Entities;

namespace AzureDemo.Services
{
  public interface IBloggingRepository
  {
    IEnumerable<Blog> GetBlogs();

    IEnumerable<Post> GetPosts(Guid blogId);
  }
}
