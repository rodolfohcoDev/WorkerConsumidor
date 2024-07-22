using System.Text.Json.Serialization;

namespace Consumer.Shareable.Response
{
    public record GoogleTagManagerModelResponse(
     [property: JsonPropertyName("id")] string id
     );
    
}
