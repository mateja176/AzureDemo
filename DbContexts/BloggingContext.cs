using System;
using System.Collections.Generic;
using AzureDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace AzureDemo.DbContexts
{
  public class BloggingContext : DbContext
  {
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

    public BloggingContext(DbContextOptions<BloggingContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Blog>().HasData(
          new Blog()
          {
            BlogId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
            Url = "https://example.com"
          },
          new Blog()
          {
            BlogId = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
            Url = "https://example.com"
          },
          new Blog()
          {
            BlogId = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
            Url = "https://example.com"
          },
          new Blog()
          {
            BlogId = Guid.Parse("102b566b-ba1f-404c-b2df-e2cde39ade09"),
            Url = "https://example.com"
          }
          );

      modelBuilder.Entity<Post>().HasData(
         new Post
         {
           PostId = Guid.Parse("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
           Title = "Commandeering a Ship Without Getting Caught",
           Content = "Commandeering a ship in rough waters isn't easy.  Commandeering it without getting caught is even harder.  In this course you'll learn how to sail away and avoid those pesky musketeers.",
           BlogId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35")
         },
         new Post
         {
           PostId = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
           Title = "Overthrowing Mutiny",
           Content = "In this course, the author provides tips to avoid, or, if needed, overthrow pirate mutiny.",
           BlogId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35")
         },
         new Post
         {
           PostId = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
           Title = "Avoiding Brawls While Drinking as Much Rum as You Desire",
           Content = "Every good pirate loves rum, but it also has a tendency to get you into trouble.  In this course you'll learn how to avoid that.  This new exclusive edition includes an additional chapter on how to run fast without falling while drunk.",
           BlogId = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450")
         },
         new Post
         {
           PostId = Guid.Parse("40ff5488-fdab-45b5-bc3a-14302d59869a"),
           Title = "Singalong Pirate Hits",
           Content = "In this course you'll learn how to sing all-time favorite pirate songs without sounding like you actually know the words or how to hold a note.",
           BlogId = Guid.Parse("102b566b-ba1f-404c-b2df-e2cde39ade09")
         }
         );

      base.OnModelCreating(modelBuilder);
    }
  }
}
