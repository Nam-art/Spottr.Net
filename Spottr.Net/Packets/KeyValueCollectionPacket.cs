namespace Spottr.Net.Packets;

/// <summary>
/// Represents a <see cref="KeyValueCollectionPacket{TKey, TValue}"/> for consumption in Spottr.
/// </summary>
public class KeyValueCollectionPacket<TKey, TValue> : SpottrPacket {

    #region Properties

    public IEnumerable<KeyValuePair<TKey, TValue>>? KeyValuePairs { get; set; } = null;

    #endregion

    #region Constructor

    public KeyValueCollectionPacket(IEnumerable<KeyValuePair<TKey, TValue>> keyValuePairs, ResourceIdentity creator) :
        base(DateTime.Now, creator) =>
            KeyValuePairs = keyValuePairs;

    #endregion

}