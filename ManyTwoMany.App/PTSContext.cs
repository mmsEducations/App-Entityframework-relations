// See https://aka.ms/new-console-template for more information
using ManyTwoMany.App.Entities;
using Microsoft.EntityFrameworkCore;
//Fluent Api
/*
  HasOne,WithOne 
  WithMany,HasMany
 */


public class PTSContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=PTSApp;Integrated Security=true;Encrypt=False");
    }

}











//Entityler arasında ilişkiler Neden kurulur?
/*
  1) Data Consistency : Veri tutarlılığı 
  2) Navigation Propertyler aracılığı ile ilişkili tablolardan veri çekebiliyoruz 
    eager loding : Bilinçli olarak neye ihtiyacın varsa onu yükleriz
    lazy loading : Hantal Yükleme 
 */

//Personel pEsra = new Personel();
//pEsra.PersonelAddress.Address

//lazy loading 
//eager loding 
//PTSContext context = new PTSContext();
//context.Personels.FirstOrDefault().PersonelAddress.Address;