// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

[Table("BookAuthors")]
public class BookAuthor
{
    [ForeignKey("Book")]
    public int BookId { get; set; }

    [ForeignKey("Author")]
    public int AuthorId { get; set; }
    public Author Author { get; set; }
    public Book Book { get; set; }
}

