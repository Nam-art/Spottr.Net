namespace Spottr.Net;

/// <summary>
/// Represents a <see cref="ResourceIdentity"/> to enable identification of resources within Spottr.
/// </summary>
public class ResourceIdentity : IDisplayable<object?> {

    #region IDisplayable Implementation

    public object? Id { get; set; } = null;
    public string? DisplayName { get; set; } = null;

    #endregion

}