namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601
{
    using Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.PowerShell;

    /// <summary>Hyperscale node edition capabilities.</summary>
    [System.ComponentModel.TypeConverter(typeof(HyperscaleNodeEditionCapabilityTypeConverter))]
    public partial class HyperscaleNodeEditionCapability
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.HyperscaleNodeEditionCapability"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapability"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapability DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new HyperscaleNodeEditionCapability(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.HyperscaleNodeEditionCapability"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapability"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapability DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new HyperscaleNodeEditionCapability(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="HyperscaleNodeEditionCapability" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapability FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.HyperscaleNodeEditionCapability"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal HyperscaleNodeEditionCapability(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal)this).SupportedStorageEdition = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IStorageEditionCapability[]) content.GetValueForProperty("SupportedStorageEdition",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal)this).SupportedStorageEdition, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IStorageEditionCapability>(__y, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.StorageEditionCapabilityTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal)this).SupportedServerVersion = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerVersionCapability[]) content.GetValueForProperty("SupportedServerVersion",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal)this).SupportedServerVersion, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerVersionCapability>(__y, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ServerVersionCapabilityTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal)this).SupportedNodeType = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INodeTypeCapability[]) content.GetValueForProperty("SupportedNodeType",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal)this).SupportedNodeType, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INodeTypeCapability>(__y, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.NodeTypeCapabilityTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal)this).Status, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.HyperscaleNodeEditionCapability"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal HyperscaleNodeEditionCapability(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal)this).SupportedStorageEdition = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IStorageEditionCapability[]) content.GetValueForProperty("SupportedStorageEdition",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal)this).SupportedStorageEdition, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IStorageEditionCapability>(__y, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.StorageEditionCapabilityTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal)this).SupportedServerVersion = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerVersionCapability[]) content.GetValueForProperty("SupportedServerVersion",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal)this).SupportedServerVersion, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerVersionCapability>(__y, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ServerVersionCapabilityTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal)this).SupportedNodeType = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INodeTypeCapability[]) content.GetValueForProperty("SupportedNodeType",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal)this).SupportedNodeType, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INodeTypeCapability>(__y, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.NodeTypeCapabilityTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal)this).Status, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Hyperscale node edition capabilities.
    [System.ComponentModel.TypeConverter(typeof(HyperscaleNodeEditionCapabilityTypeConverter))]
    public partial interface IHyperscaleNodeEditionCapability

    {

    }
}