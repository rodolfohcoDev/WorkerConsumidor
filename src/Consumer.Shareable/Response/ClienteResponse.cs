using System.Text.Json.Serialization;

namespace Consumer.Shareable.Response
{
    public record ClienteResponse(
        [property: JsonPropertyName("id")] int Id
        );
    
}
