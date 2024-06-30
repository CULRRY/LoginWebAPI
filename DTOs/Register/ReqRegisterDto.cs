using System.Text.Json.Serialization;

namespace LoginWebAPI.DTOs.Register
{
    public class ReqRegisterDto
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
