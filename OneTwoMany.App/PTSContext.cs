// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;

public class PTSContext : DbContext
{
    public DbSet<Personel> Personels { get; set; }
    public DbSet<Department> Departments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=PTSApp;Integrated Security=true;Encrypt=False");
        //İlgili provider ile hangi sunucu ,database ve hangi authontication bilgileri ile bağlanacaz vb ayarlar burda yapılır 
    }
}