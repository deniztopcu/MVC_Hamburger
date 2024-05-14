using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Hamburger.Models.Concrete;
using MVC_Hamburger.Models.Enums;

namespace MVC_Hamburger.DAL.EntityConfiguration
{
    public class MenuCFG : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Ad).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.ResimYolu).HasColumnType("varchar").HasMaxLength(100);
           
            builder.Property(x => x.Fiyat).HasColumnType("money");
            builder.HasData(
                new Menu() { ID=1 ,Ad="hamburger", Fiyat=159, ResimYolu="sfdsfa" },
                new Menu() { ID=2 ,Ad="burger",  Fiyat=169, ResimYolu = "sfdsfa" }
                );
        }
    }
}
