using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Hamburger.Models.Concrete;

namespace MVC_Hamburger.DAL.EntityConfiguration
{
    public class EkstraMalzemeCFG : IEntityTypeConfiguration<EkstraMalzeme>
    {
        public void Configure(EntityTypeBuilder<EkstraMalzeme> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Ad).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.Fiyat).HasColumnType("money");
            builder.HasOne(x => x.Kategori).WithMany(x => x.EkstraMalzemeler).HasForeignKey(x => x.KategoriID);
            builder.HasData(
                new EkstraMalzeme() { ID=1, Ad="ketçap", Fiyat=20, KategoriID=1 },
                new EkstraMalzeme() { ID=2, Ad="mayonez", Fiyat=20, KategoriID=2 }
                );
        }
    }
}
