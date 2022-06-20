namespace Spottr.Net;

/// <summary>
/// Represents a <see cref="ChartType"/> which enables Spottr to display data in different types of charts.
/// </summary>
[Flags]
public enum ChartType : long {
    /// <summary>
    /// No chart type specified.
    /// </summary>
    None = 0,
    /// <summary>
    /// A series of data points called 'markers' connected by straight line segments.
    /// </summary>
    Line = 1L << 0,
    /// <summary>
    /// A series of data points called 'markers' connected by straight line segments, filled with color from the base of the chart to each marker.
    /// </summary>
    Area = 1L << 1,
    /// <summary>
    /// Presents categorical data with rectangular bars with heights proportional to the values that they represent.
    /// </summary>
    Bar = 1L << 2,
    /// <summary>
    /// A circular statistical graphic, which is divided into slices to illustrate numerical proportion.
    /// </summary>
    Pie = 1L << 3,
    /// <summary>
    /// Similar to a bar chart where each "candle" represents four important pieces of information for the time period it represents: starting and ending values in the thick body; high and low values in the “candle wick”.
    /// </summary>
    Candlestick = 1L << 4,
    /// <summary>
    /// A mathematical diagram using Cartesian coordinates to display values for typically two variables for a set of data.
    /// </summary>
    ScatterPlot = 1L << 5,
    /// <summary>
    /// A type of bar chart that illustrates a project schedule.
    /// </summary>
    Gantt = 1L << 6,
    /// <summary>
    /// Used to visualize hierarchical data, depicted by concentric circles where the circle in the center represents the root node, with the hierarchy moving outward from the center.
    /// </summary>
    Concentric = 1L << 7,
    /// <summary>
    /// Shows magnitude of a phenomenon as color in two dimensions. The variation in color may be by hue or intensity, giving obvious visual cues to the reader about how the phenomenon is clustered or varies over space.
    /// </summary>
    Heatmap = 1L << 8,
    /// <summary>
    /// A type of line chart that shows the area above and below a threshold.
    /// </summary>
    Surplus = 1L << 9,
}