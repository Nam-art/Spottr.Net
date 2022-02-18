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

    #endregion

}