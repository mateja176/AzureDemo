using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AzureDemo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogId = table.Column<Guid>(nullable: false),
                    Url = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogId);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Content = table.Column<string>(nullable: false),
                    BlogId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "BlogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "BlogId", "Url" },
                values: new object[,]
                {
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "https://example.com" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), "https://example.com" },
                    { new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), "https://example.com" },
                    { new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"), "https://example.com" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "BlogId", "Content", "Title" },
                values: new object[,]
                {
                    { new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Commandeering a ship in rough waters isn't easy.  Commandeering it without getting caught is even harder.  In this course you'll learn how to sail away and avoid those pesky musketeers.", "Commandeering a Ship Without Getting Caught" },
                    { new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "In this course, the author provides tips to avoid, or, if needed, overthrow pirate mutiny.", "Overthrowing Mutiny" },
                    { new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), "Every good pirate loves rum, but it also has a tendency to get you into trouble.  In this course you'll learn how to avoid that.  This new exclusive edition includes an additional chapter on how to run fast without falling while drunk.", "Avoiding Brawls While Drinking as Much Rum as You Desire" },
                    { new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"), new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"), "In this course you'll learn how to sing all-time favorite pirate songs without sounding like you actually know the words or how to hold a note.", "Singalong Pirate Hits" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_BlogId",
                table: "Posts",
                column: "BlogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
