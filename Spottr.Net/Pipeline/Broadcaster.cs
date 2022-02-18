namespace Spottr.Net.Pipeline;

/// <summary>
/// Represents a <see cref="Broadcaster"/> within Spottr enabled communication systems.
/// </summary>
public abstract class Broadcaster : IDisplayable<Guid?> {

    #region IDisplayable<T> Implementation

    public Guid? Id { get; set; }
    public string? DisplayName { get; set; }

    #endregion

}