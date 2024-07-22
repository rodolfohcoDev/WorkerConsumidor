using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Consumer.Shareable.Request
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public record BuiltInVariable(
        [property: JsonPropertyName("accountId")] string accountId,
        [property: JsonPropertyName("containerId")] string containerId,
        [property: JsonPropertyName("type")] string type,
        [property: JsonPropertyName("name")] string name
    );

    public record ConsentSettings(
        [property: JsonPropertyName("consentStatus")] string consentStatus
    );

    public record Container(
        [property: JsonPropertyName("path")] string path,
        [property: JsonPropertyName("accountId")] string accountId,
        [property: JsonPropertyName("containerId")] string containerId,
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("publicId")] string publicId,
        [property: JsonPropertyName("usageContext")] IReadOnlyList<string> usageContext,
        [property: JsonPropertyName("fingerprint")] string fingerprint,
        [property: JsonPropertyName("tagManagerUrl")] string tagManagerUrl,
        [property: JsonPropertyName("features")] Features features,
        [property: JsonPropertyName("tagIds")] IReadOnlyList<string> tagIds
    );

    public record ContainerVersion(
        [property: JsonPropertyName("path")] string path,
        [property: JsonPropertyName("accountId")] string accountId,
        [property: JsonPropertyName("containerId")] string containerId,
        [property: JsonPropertyName("containerVersionId")] string containerVersionId,
        [property: JsonPropertyName("container")] Container container,
        [property: JsonPropertyName("tag")] IReadOnlyList<Tag> tag,
        [property: JsonPropertyName("trigger")] IReadOnlyList<Trigger> trigger,
        [property: JsonPropertyName("variable")] IReadOnlyList<Variable> variable,
        [property: JsonPropertyName("builtInVariable")] IReadOnlyList<BuiltInVariable> builtInVariable,
        [property: JsonPropertyName("fingerprint")] string fingerprint,
        [property: JsonPropertyName("tagManagerUrl")] string tagManagerUrl,
        [property: JsonPropertyName("customTemplate")] IReadOnlyList<CustomTemplate> customTemplate
    );

    public record CustomEventFilter(
        [property: JsonPropertyName("type")] string type,
        [property: JsonPropertyName("parameter")] IReadOnlyList<Parameter> parameter
    );

    public record CustomTemplate(
        [property: JsonPropertyName("accountId")] string accountId,
        [property: JsonPropertyName("containerId")] string containerId,
        [property: JsonPropertyName("templateId")] string templateId,
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("fingerprint")] string fingerprint,
        [property: JsonPropertyName("templateData")] string templateData,
        [property: JsonPropertyName("galleryReference")] GalleryReference galleryReference
    );

    public record Features(
        [property: JsonPropertyName("supportUserPermissions")] bool? supportUserPermissions,
        [property: JsonPropertyName("supportEnvironments")] bool? supportEnvironments,
        [property: JsonPropertyName("supportWorkspaces")] bool? supportWorkspaces,
        [property: JsonPropertyName("supportGtagConfigs")] bool? supportGtagConfigs,
        [property: JsonPropertyName("supportBuiltInVariables")] bool? supportBuiltInVariables,
        [property: JsonPropertyName("supportClients")] bool? supportClients,
        [property: JsonPropertyName("supportFolders")] bool? supportFolders,
        [property: JsonPropertyName("supportTags")] bool? supportTags,
        [property: JsonPropertyName("supportTemplates")] bool? supportTemplates,
        [property: JsonPropertyName("supportTriggers")] bool? supportTriggers,
        [property: JsonPropertyName("supportVariables")] bool? supportVariables,
        [property: JsonPropertyName("supportVersions")] bool? supportVersions,
        [property: JsonPropertyName("supportZones")] bool? supportZones,
        [property: JsonPropertyName("supportTransformations")] bool? supportTransformations
    );

    public record Filter(
        [property: JsonPropertyName("type")] string type,
        [property: JsonPropertyName("parameter")] IReadOnlyList<Parameter> parameter
    );

    public record FormatValue(

    );

    public record GalleryReference(
        [property: JsonPropertyName("host")] string host,
        [property: JsonPropertyName("owner")] string owner,
        [property: JsonPropertyName("repository")] string repository,
        [property: JsonPropertyName("version")] string version,
        [property: JsonPropertyName("signature")] string signature
    );

    public record MonitoringMetadata(
        [property: JsonPropertyName("type")] string type
    );

    public record Parameter(
        [property: JsonPropertyName("type")] string type,
        [property: JsonPropertyName("key")] string key,
        [property: JsonPropertyName("value")] string value
    );

    public record GtmModel(
        [property: JsonPropertyName("exportFormatVersion")] int? exportFormatVersion,
        [property: JsonPropertyName("exportTime")] string exportTime,
        [property: JsonPropertyName("containerVersion")] ContainerVersion containerVersion
    );

    public record Tag(
        [property: JsonPropertyName("accountId")] string accountId,
        [property: JsonPropertyName("containerId")] string containerId,
        [property: JsonPropertyName("tagId")] string tagId,
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("type")] string type,
        [property: JsonPropertyName("parameter")] IReadOnlyList<Parameter> parameter,
        [property: JsonPropertyName("fingerprint")] string fingerprint,
        [property: JsonPropertyName("firingTriggerId")] IReadOnlyList<string> firingTriggerId,
        [property: JsonPropertyName("tagFiringOption")] string tagFiringOption,
        [property: JsonPropertyName("monitoringMetadata")] MonitoringMetadata monitoringMetadata,
        [property: JsonPropertyName("consentSettings")] ConsentSettings consentSettings
    );

    public record Trigger(
        [property: JsonPropertyName("accountId")] string accountId,
        [property: JsonPropertyName("containerId")] string containerId,
        [property: JsonPropertyName("triggerId")] string triggerId,
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("type")] string type,
        [property: JsonPropertyName("filter")] IReadOnlyList<Filter> filter,
        [property: JsonPropertyName("fingerprint")] string fingerprint,
        [property: JsonPropertyName("customEventFilter")] IReadOnlyList<CustomEventFilter> customEventFilter
    );

    public record Variable(
        [property: JsonPropertyName("accountId")] string accountId,
        [property: JsonPropertyName("containerId")] string containerId,
        [property: JsonPropertyName("variableId")] string variableId,
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("type")] string type,
        [property: JsonPropertyName("parameter")] IReadOnlyList<Parameter> parameter,
        [property: JsonPropertyName("fingerprint")] string fingerprint,
        [property: JsonPropertyName("formatValue")] FormatValue formatValue
    );


}
