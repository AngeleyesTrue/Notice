using AE.Notice.Common.Domain.Common;

namespace AE.Notice.Common.Domain.Entities;

public class PostData : BaseAuditableEntity
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
}
