using System.Text.Json.Serialization;

namespace Consumer.Shareable.Response
{
    public record WebHookResponse(
        [property: JsonPropertyName("id")] int Id
        );
}
