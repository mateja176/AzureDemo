using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AzureDemo.Entities
{
  public class Blog
  {
    [Key]
    public Guid BlogId { get; set; }
    [Required]
    public string Url { get; set; }

    public ICollection<Post> Posts { get; } = new List<Post>();
  }
}
