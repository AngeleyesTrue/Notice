using AE.Notice.Common.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AE.Notice.Common.Application.Common.Interface;

public interface IApplicationDbContext
{
    DbSet<PostData> Posts { get; }
}
