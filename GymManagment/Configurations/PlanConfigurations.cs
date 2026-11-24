using GymManagment.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagment.Configurations
{
    public class PlanConfigurations : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {

            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");

            builder.ToTable("Plans", table =>
            {
                table.HasCheckConstraint(
                    "CK_Plan_DurationDays",
                    "DurationDays BETWEEN 1 AND 365"
                );
            });
        }
    }
}
