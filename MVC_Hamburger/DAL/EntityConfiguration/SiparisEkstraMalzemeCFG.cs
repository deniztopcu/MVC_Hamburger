using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Hamburger.Models.Concrete;

namespace MVC_Hamburger.DAL.EntityConfiguration
{
    public class SiparisEkstraMalzemeCFG : IEntityTypeConfiguration<SiparisEkstraMalzeme>
    {
        public void Configure(EntityTypeBuilder<SiparisEkstraMalzeme> builder)
        {
            builder.HasKey(x => new { x.EkstraMalzemeID, x.SiparisID });
            builder.HasOne(x => x.Siparis).WithMany(x => x.SiparisEkstraMalzemeler).HasForeignKey(x => x.SiparisID);
            builder.HasOne(x => x.EkstraMalzeme).WithMany(x => x.SiparisEkstraMalzemeler).HasForeignKey(x => x.EkstraMalzemeID);
        }
    }
}
