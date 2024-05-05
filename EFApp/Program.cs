// See https://aka.ms/new-console-template for more information
using EFApp.Entities;
using Microsoft.EntityFrameworkCore;



OzBlogContext context = new OzBlogContext();
//context.Categories.Add(new Category() { CategoryName = "Css", Description = "Css.." });

//Address adresIstanbul = new Address() { AddressName = "Münihe-Almanya", Author = new Author() { Email = "hitler@hotmailcom", Name = "Hitler", LastName = "Tx" } };
//context.Address.Add(adresIstanbul);

//context.SaveChanges();
List<Article> articles = context.Articles.Include("Category").ToList();
List<Article> articles2 = context.Articles
                                 .Include(x => x.Category)
                                 .Include(x => x.Author)
                                 .ToList();

Article article = context.Articles.Where(x => x.ArticleId == 1)
                                    .Include(x => x.Category).
                                     FirstOrDefault();
Console.WriteLine("Hello, World!");

/*
  Bir entitiynin ilişkili olduğu entitiylerin verilerini Getirme yöntemi 

  Eager Loading 
  Include metod ile istediğimiz ilişkili olan diğer entityleri getirebiliriz 
  Include kullanılabilmesi için bizim mutlaka IQueryable bir yapı ile çalışmamaız gerekiyor 
 */