using System.Text.Json.Serialization; 

namespace dtolab.tests.sample6.DTOs { 
    public class AdditionalDocument { 
        public string id { get; init; } 
        public string name { get; init; } 
        [JsonPropertyName("$type")]
        public string type { get; init; } 
    }
} 