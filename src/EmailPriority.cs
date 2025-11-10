using Intellenum;

namespace Soenneker.Enums.Email.Priority;

/// <summary>
/// An enumerator for email priorities
/// </summary>
[Intellenum<string>]
public sealed partial class EmailPriority
{
    public static readonly EmailPriority Low = new(nameof(Low));

    public static readonly EmailPriority Normal = new(nameof(Normal));

    public static readonly EmailPriority High = new(nameof(High));
}
