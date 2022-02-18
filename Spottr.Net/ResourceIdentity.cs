namespace Spottr.Net;

/// <summary>
/// Represents a <see cref="ResourceIdentity"/> to enable identification of resources within Spottr.
/// </summary>
public class ResourceIdentity {
    

    #region Properties

    /// <summary>
    /// The unique identifier for this resource in your systems.
    /// </summary>
    /// <value></value>
    public object? Id { get; set; } = null;
    /// <summary>
    /// The display name that should be utilized in Spottr's user interface.
    /// </summary>
    /// <value></value>
    public string? DisplayName { get; set; } = null;

    #endregion

}