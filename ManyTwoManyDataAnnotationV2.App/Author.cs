// See https://aka.ms/new-console-template for more information
public class Author
{
    public int Id { get; set; }
    public string AuthorName { get; set; }
    public string Address { get; set; }

    public ICollection<BookAuthor> Book { get; set; }//Yazarın kitapları 
}

