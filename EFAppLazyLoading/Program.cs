// See https://aka.ms/new-console-template for more information
using EFApp.Entities;



OzBlogContext context = new OzBlogContext();

Article article = context.Articles.Where(x => x.ArticleId == 1)
                  .FirstOrDefault();

Console.WriteLine("Hello, World!");
