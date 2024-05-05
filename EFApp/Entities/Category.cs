using Microsoft.EntityFrameworkCore;

namespace EFApp.Entities
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public Category Category { get; set; }
        //public int CategoryId { get; set; }
        public Author Author { get; set; }
        //public int AuthorId { get; set; }

    }
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public ICollection<Article> Articles { get; set; }

    }
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<Article> Articles { get; set; }
        public Address Address { get; set; }
    }
    public class Address
    {
        public int AddressId { get; set; }
        public string AddressName { get; set; }
        public Author Author { get; set; }

        public int AuthorId { get; set; }
    }

    public class OzBlogContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Address> Address { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=OzBlog;Integrated Security=true;Encrypt=False");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category() { CategoryId = 1, CategoryName = "C#", Description = "C# ..." });
            modelBuilder.Entity<Category>().HasData(new Category() { CategoryId = 2, CategoryName = "Web Api", Description = "Web Api ..." });
            modelBuilder.Entity<Category>().HasData(new Category() { CategoryId = 3, CategoryName = "Html", Description = "Html.." });
        }
    }

}


