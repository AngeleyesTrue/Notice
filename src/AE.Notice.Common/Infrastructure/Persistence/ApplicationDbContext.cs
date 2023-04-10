using AE.Notice.Common.Application.Common.Interface;
using AE.Notice.Common.Domain.Entities;
using AE.Notice.Common.Infrastructure.Identity;
using AE.Notice.Common.Infrastructure.Persistence.Interceptors;
using MediatR;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AE.Notice.Common.Infrastructure.Persistence;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
{
    private readonly IMediator _mediator;
    private readonly AuditableEntitySaveChangesInterceptor _auditableEntitySaveChangesInterceptor;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
        IMediator mediator,
        AuditableEntitySaveChangesInterceptor auditableEntitySaveChangesInterceptor) : base(options)
    {
        _mediator = mediator;
        _auditableEntitySaveChangesInterceptor = auditableEntitySaveChangesInterceptor;
    }

    public DbSet<PostData> Posts => Set<PostData>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);

        foreach (var entityType in builder.Model.GetEntityTypes())
        {
            var tableName = entityType.GetTableName();
            switch (tableName)
            {
                case "DeviceCodes":
                    entityType.SetTableName("tb_IdentityDeviceCodes");
                    break;
                case "Keys":
                    entityType.SetTableName("tb_IdentityKeys");
                    break;
                case "PersistedGrants":
                    entityType.SetTableName("tb_IdentityPersistedGrants");
                    break;
                default:
                    if (tableName!.StartsWith("AspNet"))
                        entityType.SetTableName(tableName.Replace("AspNet", "tb_Identity"));
                    break;
            }
        }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.AddInterceptors(_auditableEntitySaveChangesInterceptor);
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        await _mediator.DispatchDomainEvents(this);

        return await base.SaveChangesAsync(cancellationToken);
    }
}
