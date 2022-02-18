namespace Spottr.Net;

/// <summary>
/// Represents an <see cref="IDisplayable{T}"/> to enable display of an object with Spottr's user interface.
/// </summary>
/// <typeparam name="T">The type of data utilized to represent the identifier of the <see cref="IDisplayable{T}" />.</typeparam>
public interface IDisplayable<T> {

    #region Properties

    /// <summary>
    /// The unique identifier representing this object.
    /// </summary>
    T? Id { get; set; }
    /// <summary>
    /// The display name that should be utilized in Spottr's user interface.
    /// </summary>
    string? DisplayName { get; set; }

    #endregion

}