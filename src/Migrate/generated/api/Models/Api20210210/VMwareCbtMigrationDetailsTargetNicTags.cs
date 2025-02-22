namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>The tags for the target NICs.</summary>
    public partial class VMwareCbtMigrationDetailsTargetNicTags :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsTargetNicTags,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsTargetNicTagsInternal
    {

        /// <summary>Creates an new <see cref="VMwareCbtMigrationDetailsTargetNicTags" /> instance.</summary>
        public VMwareCbtMigrationDetailsTargetNicTags()
        {

        }
    }
    /// The tags for the target NICs.
    public partial interface IVMwareCbtMigrationDetailsTargetNicTags :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IAssociativeArray<string>
    {

    }
    /// The tags for the target NICs.
    internal partial interface IVMwareCbtMigrationDetailsTargetNicTagsInternal

    {

    }
}