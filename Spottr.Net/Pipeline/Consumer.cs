namespace Spottr.Net.Pipeline;

/// <summary>
/// Represents a <see cref="Consumer"/> within Spottr enabled communication systems.
/// </summary>
public abstract class Consumer : IDisplayable<Guid?> {

    #region IDisplayable<T> Implementation

    public Guid? Id { get; set; }
    public string? DisplayName { get; set; }

    #endregion

}