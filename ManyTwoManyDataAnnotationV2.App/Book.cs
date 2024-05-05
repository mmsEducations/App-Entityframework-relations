// See https://aka.ms/new-console-template for more information
/*
Data Annotation Yöntemi 
Ara-Cross tablo elle-manuel olarak oluşturulmalıdır 
Composite primary key oluşturmak için malesef data annotation ile işi kurtaramıyoruz çünkü 2 tane key verdiğimizde
Orm sapıtıyor böyle bir durumda yardımımıza FluenApi koşar 
DbSet olarak relational cross tabloyu eklemek zorunda değiliz
*/

public class Book
{
    public int Id { get; set; }
    public string BookName { get; set; }
    public string ISBNNo { get; set; }

    public ICollection<BookAuthor> Author { get; set; }//Kitabın Yazarları 
}

