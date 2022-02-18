namespace Spottr.Net;

/// <summary>
/// Represents a <see cref="CommandPacket"/> for consumption in Spottr.
/// </summary>
public class CommandPacket : SpottrPacket, IDisplayable<Guid?>
{

    #region Properties

    public Guid? Id { get; set; }
    public string? DisplayName { get; set; }

    #endregion

}