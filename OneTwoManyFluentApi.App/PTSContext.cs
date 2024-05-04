// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;

public class PTSContext : DbContext
{
    public DbSet<Personel> Personels { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Task> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=PTSApp;Integrated Security=true;Encrypt=False");
        //İlgili provider ile hangi sunucu ,database ve hangi authontication bilgileri ile bağlanacaz vb ayarlar burda yapılır 
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Personel>()
                    .HasOne(x => x.Department)
                    .WithMany(x => x.Personels)
                    .HasForeignKey(x => x.DepId);


        modelBuilder.Entity<Personel>()
                  .HasOne(x => x.Task)
                  .WithMany(x => x.Personels)
                  .HasForeignKey(x => x.TaskId);

    }
}

//x ten y giderken hasOne ,hasMany, tekrardan yden x'e giderken withOne,withMany