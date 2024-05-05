namespace ManyTwoMany.App.Entities
{
    //Default Convention ile çoka çok ilişki 
    /*
     Çoka çok ilişkiyi var olan mevcut tablolar üzerinde sağlayamadığım için mecburen yeni bir tablo 
     üzerinde çoka çok ilişkiyi sağlamam gerekir 
     
     Default Convention ile navigation propertyleri doğru yaptıktan sonra ara-cross tabloyu elle oluşturmamıza 
     gerek yok.Bunu EF orm'si kendisi yapabilir.
     Composite Key 
     Bir tabloda-entityde primary key alanı birden çok propertyden oluşuyorsa biz bu birden çok property'nin tamamına 
     Composite Key deriz 
     Composite Key örneği: BookId ve AuthorId bir bütün olarak bir arada kullanılması 

     BookId ,Name     
     1       Kavgam   
     2       Açlık
     3       Zenginlik 

     AuthorId,AuthorName 
     1        Hitler    
     2        Ozan

    
     CrossTable-Ara Tablo
               BookAuthor 
               BookId,AuthorId
 Kavgam        1      1
 kavgam        1      2
 Zenginlik     3      2


     */

    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string ISBNNo { get; set; }

        public ICollection<Author> Author { get; set; }//Kitabın Yazarları 
    }

    public class Author
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string Address { get; set; }

        public ICollection<Book> Book { get; set; }//Yazarın kitapları 
    }



}
