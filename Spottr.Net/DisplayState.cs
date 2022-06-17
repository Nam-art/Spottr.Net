namespace Spottr.Net.Packets;

/// <summary>
/// Represents a <see cref="DisplayState"/> which enables Spottr to categorize information visually.
/// </summary>
public enum DisplayState {
    /// <summary>
    /// No state provided.
    /// </summary>
    /// <remarks>This state typically represents informational data with no display preference.</remarks>
    None = 0,
    /// <summary>
    /// This state is displayed in Spottr's negative category.
    /// </summary>
    /// <remarks>This state typically represents errors, exceptions, etc.</remarks>
    Negative = 1,
    /// <summary>
    /// This state is displayed in Spottr's neutral category.
    /// </summary>
    /// <remarks>This state typically represents warnings.</remarks>
    Neutral = 2,
    /// <summary>
    /// This state is displayed in Spottr's positive category.
    /// </summary>
    /// <remarks>This state typically represents successful processing.</remarks>
    Positive = 3
}