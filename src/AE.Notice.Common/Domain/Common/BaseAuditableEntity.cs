namespace AE.Notice.Common.Domain.Common;

public abstract class BaseAuditableEntity
{
    public bool IsDeleted { get; set; }
    public DateTime Created { get; set; }
    public string? CreatedBy { get; set; }
    public string? CreatedByName { get; set; }
    public DateTime? LastModified { get; set; }
    public string? LastModifiedBy { get; set; }
    public string? LastModifiedByName { get; set; }
}
