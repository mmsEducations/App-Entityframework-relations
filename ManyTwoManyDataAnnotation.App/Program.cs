// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");



/*
Data Annotation Yöntemi 
Ara-Cross tablo elle-manuel olarak oluşturulmalıdır 
Composite primary key oluşturmak için malesef data annotation ile işi kurtaramıyoruz çünkü 2 tane key verdiğimizde
Orm sapıtıyor böyle bir durumda yardımımıza FluenApi koşar 
*/


public class Book
{
    public int Id { get; set; }
    public string BookName { get; set; }
    public string ISBNNo { get; set; }

    public ICollection<BookAuthor> Author { get; set; }//Kitabın Yazarları 
}

public class BookAuthor
{
    //[Key] orm iki tane primary key kullanımına izin vermiyor 
    public int BookId { get; set; }
    //[Key]
    public int AuthorId { get; set; }
    public Author Author { get; set; }
    public Book Book { get; set; }
}

public class Author
{
    public int Id { get; set; }
    public string AuthorName { get; set; }
    public string Address { get; set; }

    public ICollection<BookAuthor> Book { get; set; }//Yazarın kitapları 
}


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

