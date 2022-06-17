namespace Spottr.Net.Packets;

/// <summary>
/// Represents a <see cref="ChartedPacket"/> for consumption in Spottr.
/// </summary>
public class ChartedPacket : KeyValueCollectionPacket<double, double> {

    #region Properties

    /// <summary>
    /// The display name of the chart.
    /// </summary>
    /// <value></value>
    public string? Name { get; set; } = null;
    /// <summary>
    /// The type of chart this packet should be displayed with.
    /// </summary>
    /// <value></value>
    public ChartType? ChartType { get; set; } = null;

    #endregion

    #region Constructor

    public ChartedPacket(string name, ChartType chartType, IEnumerable<KeyValuePair<double, double>> chartData, ResourceIdentity creator) :
        base(chartData, creator) =>
            (Name, ChartType) = (name, chartType);

    #endregion

}