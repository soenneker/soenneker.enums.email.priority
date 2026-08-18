using Soenneker.Gen.EnumValues;

namespace Soenneker.Enums.Email.Priority;

/// <summary>
/// Identifies the delivery priority assigned to an email message.
/// </summary>
[EnumValue<string>]
public sealed partial class EmailPriority
{
    /// <summary>
    /// Low-priority delivery.
    /// </summary>
    public static readonly EmailPriority Low = new(nameof(Low));

    /// <summary>
    /// Normal-priority delivery.
    /// </summary>
    public static readonly EmailPriority Normal = new(nameof(Normal));

    /// <summary>
    /// High-priority delivery.
    /// </summary>
    public static readonly EmailPriority High = new(nameof(High));
}
