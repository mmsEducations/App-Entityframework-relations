// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;

/*
   Fluent Api yöntemiyle 1'e 1 ilişki nasıl kurulur 
*/

public class PTSContext : DbContext
{
    public DbSet<Personel> Personels { get; set; }
    public DbSet<PersonelAddress> PersonelAddresses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=PTSApp3;Integrated Security=true;Encrypt=False");
        //İlgili provider ile hangi sunucu ,database ve hangi authontication bilgileri ile bağlanacaz vb ayarlar burda yapılır 
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //PersonelAddressId adlı kolonu primary key yaptık
        modelBuilder.Entity<PersonelAddress>()
                    .HasKey(x => x.PersonelAddressId);

        //iki yönlü bire bir ilişkiyi kod olarak yazdık ve en son PersonelAddress tablosundaki PersonelAddressId alanını foreign key olarak tanımladık 
        modelBuilder.Entity<Personel>()
                    .HasOne(x => x.PersonelAddress)
                    .WithOne(x => x.Personel)
                    .HasForeignKey<PersonelAddress>(x => x.PersonelAddressId);

    }
}