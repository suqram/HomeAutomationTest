using Newtonsoft.Json;

namespace HomeAutomationTest.Models
{
    public class Home
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Rooms")]
        public Room[] Rooms { get; set; }
    }
}