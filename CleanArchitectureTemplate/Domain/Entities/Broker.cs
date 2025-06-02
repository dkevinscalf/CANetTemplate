namespace Domain.Entities;

using Domain.ValueObjects;

public class Broker : BaseAuditableEntity
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Salutation { get; set; }

    public bool PrincipleContact { get; set; }

    public string? CorrespondenceMethod { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Phone2 { get; set; }

    public string? Phone3 { get; set; }

    public string? PhoneType { get; set; }

    public string? PhoneType2 { get; set; }

    public string? PhoneType3 { get; set; }

    public bool IsDisabled { get; set; }

    public string? SourceSystem { get; set; }

    public string? SourceSystemId { get; set; }

    public IList<ExternalCode> AdditionalExternalCodes { get; private set; } = new List<ExternalCode>();

    public bool DisableNotificationOnCreate { get; set; }

    public string? Role { get; set; }
}
