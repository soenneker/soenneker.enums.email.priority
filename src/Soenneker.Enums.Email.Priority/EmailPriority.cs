using Soenneker.Gen.EnumValues;

namespace Soenneker.Enums.Email.Priority;

/// <summary>
/// An enumerator for email priorities
/// </summary>
[EnumValue<string>]
public sealed partial class EmailPriority
{
    /// <summary>
    /// The low.
    /// </summary>
    public static readonly EmailPriority Low = new(nameof(Low));

    /// <summary>
    /// The normal.
    /// </summary>
    public static readonly EmailPriority Normal = new(nameof(Normal));

    /// <summary>
    /// The high.
    /// </summary>
    public static readonly EmailPriority High = new(nameof(High));
}
