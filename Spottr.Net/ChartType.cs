namespace Spottr.Net.Packets;

/// <summary>
/// Represents a <see cref="ChartType"/> which enables Spottr to display data in different types of charts.
/// </summary>
public enum ChartType {
    /// <summary>
    /// No chart type specified.
    /// </summary>
    None = 0,
    /// <summary>
    /// A basic line chart.
    /// </summary>
    Line = 1,
    /// <summary>
    /// A basic area chart.
    /// </summary>
    Area = 2,
    /// <summary>
    /// A basic bar chart.
    /// </summary>
    Bar = 3,
    /// <summary>
    /// A basic pie chart.
    /// </summary>
    Pie = 4,
    /// <summary>
    /// A basic candlestick chart.
    /// </summary>
    Candlestick = 5,
    /// <summary>
    /// A basic scatter chart.
    /// </summary>
    Scatter = 6
}