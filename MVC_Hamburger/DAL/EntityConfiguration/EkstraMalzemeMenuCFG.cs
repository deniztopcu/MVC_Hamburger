using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Hamburger.Models.Concrete;

namespace MVC_Hamburger.DAL.EntityConfiguration
{
    public class EkstraMalzemeMenuCFG : IEntityTypeConfiguration<EkstraMalzemeMenu>
    {
        public void Configure(EntityTypeBuilder<EkstraMalzemeMenu> builder)
        {
            builder.HasKey(x => new { x.EkstraMalzemeID, x.MenuID });
            builder.HasOne(x => x.Menu).WithMany(x => x.EkstraMalzemeMenuler).HasForeignKey(x => x.MenuID);
            builder.HasOne(x => x.EkstraMalzeme).WithMany(x => x.EkstraMalzemeMenuler).HasForeignKey(x => x.EkstraMalzemeID);
        }
    }
}
