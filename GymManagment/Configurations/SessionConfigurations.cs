using GymManagment.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagment.Configurations
{
    public class SessionConfigurations : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");

            builder.ToTable("Sessions", table =>
            {
                table.HasCheckConstraint(
                    "CK_Session_Capacity",
                    "Capacity BETWEEN 1 AND 25"
                );

                table.HasCheckConstraint(
                    "CK_Session_Dates",
                    "EndDate > StartDate"
                );
            });



            builder.HasOne(x => x.Trainer)
                   .WithMany(x => x.Sessions)
                   .HasForeignKey(x => x.TrainerId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
