using Newtonsoft.Json;

namespace RandomDataToolsInterop.Models
{
    internal class ErrorResult
    {
        [JsonProperty("error_code")]
        internal string ErrorCode { get; set; }
        
        [JsonProperty("error_message")]
        internal string ErrorMessage { get; set; }

        internal bool IsEmpty() => string.IsNullOrEmpty(ErrorCode) && string.IsNullOrEmpty(ErrorMessage);
    }
}