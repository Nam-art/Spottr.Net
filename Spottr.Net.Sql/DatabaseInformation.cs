using System.Data.SqlClient;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Spottr.Net.Sql
{
    public class DatabaseInformation
    {
        /// <summary>
        /// The connection string built with the specified database.
        /// </summary>
        [JsonIgnore]
        [XmlIgnore]
        public string? ConnectionString
        {
            get
            {
                string server = Server ?? string.Empty;
                string database = DatabaseName ?? string.Empty;
                if (new string[] { server, database }.Any(a => string.IsNullOrWhiteSpace(a)))
                    return null;

                var connectionStringBuilder = new SqlConnectionStringBuilder
                {
                    InitialCatalog = database,
                    DataSource = server,
                    UserID = Username,
                    Password = Password,
                    IntegratedSecurity = false,
                    ConnectTimeout = checked((int?)Timeout?.TotalSeconds) ?? 30
                };
                return connectionStringBuilder.ConnectionString;
            }
        }
        /// <summary>
        /// The server where the database is hosted.
        /// </summary>
        public string? Server { get; set; } = null;
        /// <summary>
        /// The name of the database to connect to.
        /// </summary>
        public string? DatabaseName { get; set; } = null;
        /// <summary>
        /// The username that should be used to authenticate to the database.
        /// </summary>
        public string? Username { get; set; } = null;
        /// <summary>
        /// The password used to authenticate to the database.
        /// </summary>
        public string? Password { get; set; } = null;
        /// <summary>
        /// The length of time connections are allowed to run without a response before timing out.
        /// </summary>
        public TimeSpan? Timeout { get; set; } = null;
    }
}
