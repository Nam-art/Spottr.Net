namespace Spottr.Net.Pipeline;

/// <summary>
/// Represents a <see cref="Broadcaster"/> within Spottr enabled communication systems.
/// </summary>
public abstract class Broadcaster : IDisplayable<Guid?> {

    #region IDisplayable<T> Implementation

    public Guid? Id { get; set; }
    public string? DisplayName { get; set; }

    #endregion

    #region Public Methods

    /// <summary>
    /// Broadcasts a <see cref="SpottrPacket" /> for consumption.
    /// </summary>
    /// <param name="packet">The <see cref="SpottrPacket" /> that should be broadcast to consumers.</param>
    /// <typeparam name="T">The type of <set cref="SpottrPacket" /> that is being broadcast.</typeparam>
    public abstract void Broadcast<T>(T packet) where T : SpottrPacket;

    #endregion

}