namespace Spottr.Net.Packets;

/// <summary>
/// Represents a <see cref="MessagePacket"/> for consumption in Spottr.
/// </summary>
public class MessagePacket : SpottrPacket {

    #region Properties

    public string? Message { get; set; } = null;

    #endregion

    #region Constructor

    public MessagePacket(string message, ResourceIdentity creator) :
        base(DateTime.Now, creator) =>
            Message = message;

    #endregion

}