// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;

public class PTSContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=PTSApp;Integrated Security=true;Encrypt=False");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Amaç BookAuthor tablosunun 2 alanını composite key olarak tanımlamak 
        modelBuilder.Entity<BookAuthor>()
            .HasKey(a => new { a.BookId, a.AuthorId });//ikitane alan için key olşuturuyoruz aynı zamanda composite key oluşturmuş oluyoruz

    }
}

