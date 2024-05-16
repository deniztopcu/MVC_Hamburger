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
                new EkstraMalzeme() { ID = 3, Ad = "Sos İstemiyorum", Fiyat = 0, KategoriID = 3 }
                );
        }
    }
}
