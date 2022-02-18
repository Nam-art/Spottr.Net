namespace Spottr.Net;

/// <summary>
/// Represents a packet containing a packet.
/// </summary>
/// <typeparam name="T"></typeparam>
public class EmbededPacket<T> : SpottrPacket where T : SpottrPacket {

    #region Properties

    /// <summary>
    /// The packet embeded within this packet.
    /// </summary>
    public T? Packet { get; set; } = null;

    #endregion

}