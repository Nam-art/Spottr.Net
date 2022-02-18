namespace Spottr.Net;

/// <summary>
/// Represents a <see cref="CommandPacket"/> for consumption in Spottr.
/// </summary>
public class CommandPacket
{

    #region Properties

    /// <summary>
    /// The unique runtime identifier for the command this packet represents.
    /// </summary>
    public Guid? Id { get; set; } = null;
    /// <summary>
    /// The name used to display the command in Spottr.
    /// </summary>
    public string? DisplayName { get; set; } = null;

    #endregion

}