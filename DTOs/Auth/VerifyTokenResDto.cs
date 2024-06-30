using System.Text.Json.Serialization;

namespace LoginWebAPI.DTOs.Auth
{
    public class VerifyTokenResDto
    {
        [JsonPropertyName("id")]
        public UInt64 Id { get; set; }

        [JsonPropertyName("account_id")]
        public string accountId { get; set; }
    }
}
