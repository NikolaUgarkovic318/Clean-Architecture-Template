namespace Domain.Common;

public abstract class BaseAuditableEntity: BaseEntity
{
    public DateTime CreatedAt { get; set; }
    public DateTime LastModifyAt { get; set; }
    public string? CreatedBy { get; set; }
    public string? LastModefyBy { get; set; }
}

