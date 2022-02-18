namespace Spottr.Net;

/// <summary>
/// Represents a <see cref="ProgressPacket"/> for consumption in Spottr.
/// </summary>
public class ProgressPacket
{

    #region Properties

    /// <summary>
    /// The number of "things" that have been successfully processed.
    /// </summary>
    public int Is { get; set; }
    /// <summary>
    /// The number of "things" that are expected to be processed.
    /// </summary>
    public int Of { get; set; }

    #endregion

}