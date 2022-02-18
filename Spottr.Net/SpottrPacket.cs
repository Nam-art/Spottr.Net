namespace Spottr.Net;

/// <summary>
/// Represents the basic requirements for a packet to be consumed by Spottr.
/// </summary>
public abstract class SpottrPacket {

    #region Properties

    /// <summary>
    /// The moment in time at which this packet was created.
    /// </summary>
    public DateTime? MomentOfCreation { get; set; } = null;
    /// <summary>
    /// The resource responsible for creating this packet.
    /// </summary>
    /// <value></value>
    public ResourceIdentity? Creator { get; set; } = null;

    #endregion

}