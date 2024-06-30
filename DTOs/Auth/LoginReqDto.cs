using System.Text.Json.Serialization;

namespace LoginWebAPI.DTOs.Auth
{
    public class LoginReqDto
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
