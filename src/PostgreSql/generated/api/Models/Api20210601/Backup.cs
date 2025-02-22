namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>Backup properties of a server</summary>
    public partial class Backup :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IBackup,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IBackupInternal
    {

        /// <summary>Backing field for <see cref="EarliestRestoreDate" /> property.</summary>
        private global::System.DateTime? _earliestRestoreDate;

        /// <summary>The earliest restore point time (ISO8601 format) for server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public global::System.DateTime? EarliestRestoreDate { get => this._earliestRestoreDate; }

        /// <summary>Backing field for <see cref="GeoRedundantBackup" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.GeoRedundantBackupEnum? _geoRedundantBackup;

        /// <summary>A value indicating whether Geo-Redundant backup is enabled on the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.GeoRedundantBackupEnum? GeoRedundantBackup { get => this._geoRedundantBackup; set => this._geoRedundantBackup = value; }

        /// <summary>Internal Acessors for EarliestRestoreDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IBackupInternal.EarliestRestoreDate { get => this._earliestRestoreDate; set { {_earliestRestoreDate = value;} } }

        /// <summary>Backing field for <see cref="RetentionDay" /> property.</summary>
        private int? _retentionDay;

        /// <summary>Backup retention days for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public int? RetentionDay { get => this._retentionDay; set => this._retentionDay = value; }

        /// <summary>Creates an new <see cref="Backup" /> instance.</summary>
        public Backup()
        {

        }
    }
    /// Backup properties of a server
    public partial interface IBackup :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable
    {
        /// <summary>The earliest restore point time (ISO8601 format) for server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The earliest restore point time (ISO8601 format) for server.",
        SerializedName = @"earliestRestoreDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EarliestRestoreDate { get;  }
        /// <summary>A value indicating whether Geo-Redundant backup is enabled on the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether Geo-Redundant backup is enabled on the server.",
        SerializedName = @"geoRedundantBackup",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.GeoRedundantBackupEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.GeoRedundantBackupEnum? GeoRedundantBackup { get; set; }
        /// <summary>Backup retention days for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Backup retention days for the server.",
        SerializedName = @"backupRetentionDays",
        PossibleTypes = new [] { typeof(int) })]
        int? RetentionDay { get; set; }

    }
    /// Backup properties of a server
    internal partial interface IBackupInternal

    {
        /// <summary>The earliest restore point time (ISO8601 format) for server.</summary>
        global::System.DateTime? EarliestRestoreDate { get; set; }
        /// <summary>A value indicating whether Geo-Redundant backup is enabled on the server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.GeoRedundantBackupEnum? GeoRedundantBackup { get; set; }
        /// <summary>Backup retention days for the server.</summary>
        int? RetentionDay { get; set; }

    }
}