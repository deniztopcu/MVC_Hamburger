using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Hamburger.Models.Concrete;

namespace MVC_Hamburger.DAL.EntityConfiguration
{
    public class SiparisCFG : IEntityTypeConfiguration<Siparis>
    {
        public void Configure(EntityTypeBuilder<Siparis> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ToplamFiyat).HasColumnType("money");
        }
    }
}
