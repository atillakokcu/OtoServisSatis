using Microsoft.EntityFrameworkCore;
using OtoServisSatis.Entities;

namespace OtoServisSatis.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Arac> Araclar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Rol> Roller { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<Servis> Servisler { get; set; }
        public DbSet<Slider> Sliders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)// veri tabanı bağlantısı yapmak için kullandığımız yerdir
        {
            optionsBuilder.UseSqlServer(@"data source=GODSWHIP\SQLEXPRESS;initial catalog=OtoServisSatisNetCore;integrated security=True;
                MultipleActiveResultSets=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent Api
            modelBuilder.Entity<Marka>().Property(m => m.Adi).IsRequired().HasColumnType("varchar(50)");
            modelBuilder.Entity<Rol>().Property(m => m.Adi).IsRequired().HasColumnType("varchar(50)"); //IsRequired = girilmesi zorunlu demek. HasColumnType = veri tipini belirtiyor
            modelBuilder.Entity<Rol>().HasData(new Rol
            { //Hasdata veri tabanı oluşturulurken otomsatik belirtilen veriyi eklemeye yarar.
                Id = 1,
                Adi = "Admin"
            });
            modelBuilder.Entity<Kullanici>().HasData(new Kullanici
            { //Hasdata veri tabanı oluşturulurken otomsatik belirtilen veriyi eklemeye yarar.
                Id = 1,
                Adi = "Admin",
                Soyadi = "Admin",
                AktifMi = true,
                EklemeTarihi = DateTime.Now,
                Email = "admin@gmail.com",
                Sifre = "123",
                //Rol = new Rol { Id = 1, Adi = "Admin" },
                RolId = 1,
                KullaniciAdi="Admin",
                Telefon = "5554443322"

            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
//Data Source = GODSWHIP\SQLEXPRESS; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False