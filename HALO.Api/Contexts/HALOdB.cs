using Microsoft.EntityFrameworkCore;

namespace HALO.Api.Contexts;

public class HALOdB : DbContext
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<InteractionTypeEntity> InteractionTypes { get; set; }
    public DbSet<InteractionReasonEntity> InteractionReasons { get; set; }
    public DbSet<InteractionOutcomeEntity> InteractionOutcomes { get; set; }
    public DbSet<HapscaseEntity> Hapscases { get; set; }
    public DbSet<CommentEntity> Comments { get; set; }
    public DbSet<CarescaseEntity> Carescases { get; set; }
    public DbSet<OutreachEntity> Outreaches { get; set; }
    public DbSet<ClientInteractionEntity> ClientInteractions { get; set; }

    public HALOdB(DbContextOptions<HALOdB> options) : base( options )
    {
    }
}
