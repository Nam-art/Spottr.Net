namespace Spottr.Net;

/// <summary>
/// Represents a <see cref="ProgressPacket"/> for consumption in Spottr.
/// </summary>
public class ProgressPacket : SpottrPacket {

    #region Properties

    /// <summary>
    /// The number of "things" that have been successfully processed.
    /// </summary>
    public int? Is { get; set; } = null;
    /// <summary>
    /// The number of "things" that are expected to be processed.
    /// </summary>
    public int? Of { get; set; } = null;

    #endregion

    #region Constructors

    public ProgressPacket(int @is, int of, ResourceIdentity creator) :
        base(DateTime.Now, creator) =>
            (Is, Of) = (@is, of);

    #endregion

}