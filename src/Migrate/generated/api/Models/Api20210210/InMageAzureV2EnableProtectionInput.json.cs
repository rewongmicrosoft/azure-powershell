namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>VMware Azure specific enable protection input.</summary>
    public partial class InMageAzureV2EnableProtectionInput
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInput.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInput.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInput FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json ? new InMageAzureV2EnableProtectionInput(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject into a new instance of <see cref="InMageAzureV2EnableProtectionInput" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal InMageAzureV2EnableProtectionInput(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __enableProtectionProviderSpecificInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.EnableProtectionProviderSpecificInput(json);
            {_masterTargetId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("masterTargetId"), out var __jsonMasterTargetId) ? (string)__jsonMasterTargetId : (string)MasterTargetId;}
            {_processServerId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("processServerId"), out var __jsonProcessServerId) ? (string)__jsonProcessServerId : (string)ProcessServerId;}
            {_storageAccountId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("storageAccountId"), out var __jsonStorageAccountId) ? (string)__jsonStorageAccountId : (string)StorageAccountId;}
            {_runAsAccountId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("runAsAccountId"), out var __jsonRunAsAccountId) ? (string)__jsonRunAsAccountId : (string)RunAsAccountId;}
            {_multiVMGroupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("multiVmGroupId"), out var __jsonMultiVMGroupId) ? (string)__jsonMultiVMGroupId : (string)MultiVMGroupId;}
            {_multiVMGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("multiVmGroupName"), out var __jsonMultiVMGroupName) ? (string)__jsonMultiVMGroupName : (string)MultiVMGroupName;}
            {_disksToInclude = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray>("disksToInclude"), out var __jsonDisksToInclude) ? If( __jsonDisksToInclude as Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2DiskInputDetails[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2DiskInputDetails) (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2DiskInputDetails.FromJson(__u) )) ))() : null : DisksToInclude;}
            {_targetAzureNetworkId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetAzureNetworkId"), out var __jsonTargetAzureNetworkId) ? (string)__jsonTargetAzureNetworkId : (string)TargetAzureNetworkId;}
            {_targetAzureSubnetId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetAzureSubnetId"), out var __jsonTargetAzureSubnetId) ? (string)__jsonTargetAzureSubnetId : (string)TargetAzureSubnetId;}
            {_enableRdpOnTargetOption = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("enableRdpOnTargetOption"), out var __jsonEnableRdpOnTargetOption) ? (string)__jsonEnableRdpOnTargetOption : (string)EnableRdpOnTargetOption;}
            {_targetAzureVMName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetAzureVmName"), out var __jsonTargetAzureVMName) ? (string)__jsonTargetAzureVMName : (string)TargetAzureVMName;}
            {_logStorageAccountId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("logStorageAccountId"), out var __jsonLogStorageAccountId) ? (string)__jsonLogStorageAccountId : (string)LogStorageAccountId;}
            {_targetAzureV1ResourceGroupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetAzureV1ResourceGroupId"), out var __jsonTargetAzureV1ResourceGroupId) ? (string)__jsonTargetAzureV1ResourceGroupId : (string)TargetAzureV1ResourceGroupId;}
            {_targetAzureV2ResourceGroupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetAzureV2ResourceGroupId"), out var __jsonTargetAzureV2ResourceGroupId) ? (string)__jsonTargetAzureV2ResourceGroupId : (string)TargetAzureV2ResourceGroupId;}
            {_diskType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("diskType"), out var __jsonDiskType) ? (string)__jsonDiskType : (string)DiskType;}
            {_targetAvailabilitySetId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetAvailabilitySetId"), out var __jsonTargetAvailabilitySetId) ? (string)__jsonTargetAvailabilitySetId : (string)TargetAvailabilitySetId;}
            {_targetAvailabilityZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetAvailabilityZone"), out var __jsonTargetAvailabilityZone) ? (string)__jsonTargetAvailabilityZone : (string)TargetAvailabilityZone;}
            {_targetProximityPlacementGroupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetProximityPlacementGroupId"), out var __jsonTargetProximityPlacementGroupId) ? (string)__jsonTargetProximityPlacementGroupId : (string)TargetProximityPlacementGroupId;}
            {_licenseType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("licenseType"), out var __jsonLicenseType) ? (string)__jsonLicenseType : (string)LicenseType;}
            {_sqlServerLicenseType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("sqlServerLicenseType"), out var __jsonSqlServerLicenseType) ? (string)__jsonSqlServerLicenseType : (string)SqlServerLicenseType;}
            {_targetVMSize = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetVmSize"), out var __jsonTargetVMSize) ? (string)__jsonTargetVMSize : (string)TargetVMSize;}
            {_diskEncryptionSetId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("diskEncryptionSetId"), out var __jsonDiskEncryptionSetId) ? (string)__jsonDiskEncryptionSetId : (string)DiskEncryptionSetId;}
            {_targetVMTag = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("targetVmTags"), out var __jsonTargetVMTags) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2EnableProtectionInputTargetVMTags.FromJson(__jsonTargetVMTags) : TargetVMTag;}
            {_seedManagedDiskTag = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("seedManagedDiskTags"), out var __jsonSeedManagedDiskTags) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2EnableProtectionInputSeedManagedDiskTags.FromJson(__jsonSeedManagedDiskTags) : SeedManagedDiskTag;}
            {_targetManagedDiskTag = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("targetManagedDiskTags"), out var __jsonTargetManagedDiskTags) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2EnableProtectionInputTargetManagedDiskTags.FromJson(__jsonTargetManagedDiskTags) : TargetManagedDiskTag;}
            {_targetNicTag = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("targetNicTags"), out var __jsonTargetNicTags) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2EnableProtectionInputTargetNicTags.FromJson(__jsonTargetNicTags) : TargetNicTag;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="InMageAzureV2EnableProtectionInput" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="InMageAzureV2EnableProtectionInput" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __enableProtectionProviderSpecificInput?.ToJson(container, serializationMode);
            AddIf( null != (((object)this._masterTargetId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._masterTargetId.ToString()) : null, "masterTargetId" ,container.Add );
            AddIf( null != (((object)this._processServerId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._processServerId.ToString()) : null, "processServerId" ,container.Add );
            AddIf( null != (((object)this._storageAccountId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._storageAccountId.ToString()) : null, "storageAccountId" ,container.Add );
            AddIf( null != (((object)this._runAsAccountId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._runAsAccountId.ToString()) : null, "runAsAccountId" ,container.Add );
            AddIf( null != (((object)this._multiVMGroupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._multiVMGroupId.ToString()) : null, "multiVmGroupId" ,container.Add );
            AddIf( null != (((object)this._multiVMGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._multiVMGroupName.ToString()) : null, "multiVmGroupName" ,container.Add );
            if (null != this._disksToInclude)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.XNodeArray();
                foreach( var __x in this._disksToInclude )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("disksToInclude",__w);
            }
            AddIf( null != (((object)this._targetAzureNetworkId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetAzureNetworkId.ToString()) : null, "targetAzureNetworkId" ,container.Add );
            AddIf( null != (((object)this._targetAzureSubnetId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetAzureSubnetId.ToString()) : null, "targetAzureSubnetId" ,container.Add );
            AddIf( null != (((object)this._enableRdpOnTargetOption)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._enableRdpOnTargetOption.ToString()) : null, "enableRdpOnTargetOption" ,container.Add );
            AddIf( null != (((object)this._targetAzureVMName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetAzureVMName.ToString()) : null, "targetAzureVmName" ,container.Add );
            AddIf( null != (((object)this._logStorageAccountId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._logStorageAccountId.ToString()) : null, "logStorageAccountId" ,container.Add );
            AddIf( null != (((object)this._targetAzureV1ResourceGroupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetAzureV1ResourceGroupId.ToString()) : null, "targetAzureV1ResourceGroupId" ,container.Add );
            AddIf( null != (((object)this._targetAzureV2ResourceGroupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetAzureV2ResourceGroupId.ToString()) : null, "targetAzureV2ResourceGroupId" ,container.Add );
            AddIf( null != (((object)this._diskType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._diskType.ToString()) : null, "diskType" ,container.Add );
            AddIf( null != (((object)this._targetAvailabilitySetId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetAvailabilitySetId.ToString()) : null, "targetAvailabilitySetId" ,container.Add );
            AddIf( null != (((object)this._targetAvailabilityZone)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetAvailabilityZone.ToString()) : null, "targetAvailabilityZone" ,container.Add );
            AddIf( null != (((object)this._targetProximityPlacementGroupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetProximityPlacementGroupId.ToString()) : null, "targetProximityPlacementGroupId" ,container.Add );
            AddIf( null != (((object)this._licenseType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._licenseType.ToString()) : null, "licenseType" ,container.Add );
            AddIf( null != (((object)this._sqlServerLicenseType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._sqlServerLicenseType.ToString()) : null, "sqlServerLicenseType" ,container.Add );
            AddIf( null != (((object)this._targetVMSize)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetVMSize.ToString()) : null, "targetVmSize" ,container.Add );
            AddIf( null != (((object)this._diskEncryptionSetId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._diskEncryptionSetId.ToString()) : null, "diskEncryptionSetId" ,container.Add );
            AddIf( null != this._targetVMTag ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._targetVMTag.ToJson(null,serializationMode) : null, "targetVmTags" ,container.Add );
            AddIf( null != this._seedManagedDiskTag ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._seedManagedDiskTag.ToJson(null,serializationMode) : null, "seedManagedDiskTags" ,container.Add );
            AddIf( null != this._targetManagedDiskTag ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._targetManagedDiskTag.ToJson(null,serializationMode) : null, "targetManagedDiskTags" ,container.Add );
            AddIf( null != this._targetNicTag ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._targetNicTag.ToJson(null,serializationMode) : null, "targetNicTags" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}