using GymManagment.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagment.Configurations
{
    public class TrainerConfigurations : GymUserConfigurations<Trainer>, IEntityTypeConfiguration<Trainer>
    {
        public new void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");
            base.Configure(builder);
        }
    }
}
