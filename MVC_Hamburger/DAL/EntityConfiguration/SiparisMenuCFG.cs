using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Hamburger.Models.Concrete;

namespace MVC_Hamburger.DAL.EntityConfiguration
{
    public class SiparisMenuCFG : IEntityTypeConfiguration<SiparisMenu>
    {
        public void Configure(EntityTypeBuilder<SiparisMenu> builder)
        {
            builder.HasKey(x => new { x.SiparisID, x.MenuID });
            builder.HasOne(x => x.Menu).WithMany(x => x.SiparisMenuler).HasForeignKey(x => x.MenuID);
            builder.HasOne(x => x.Siparis).WithMany(x => x.SiparisMenuler).HasForeignKey(x => x.SiparisID);
        }
    }
}
