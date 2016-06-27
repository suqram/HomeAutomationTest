using Newtonsoft.Json;

namespace HomeAutomationTest.Models
{
    public class Room
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Temperature")]
        public double Temperature { get; set; }

        [JsonProperty("Humidity")]
        public double Humidity { get; set; } 
    }
}