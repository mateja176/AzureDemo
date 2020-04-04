using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AzureDemo.Entities
{
  public class Post
  {
    [Key]
    public Guid PostId { get; set; }
    [Required]
    [MaxLength(100)]
    public string Title { get; set; }
    [Required]
    public string Content { get; set; }

    public Guid BlogId { get; set; }
    [ForeignKey("BlogId")]
    public Blog Blog { get; set; }
  }
}
