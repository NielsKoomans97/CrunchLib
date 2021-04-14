using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CrunchLib
{
    public class SeasonInfo
    {
        #region Public Properties

        [JsonProperty("collection_id")]
        public long Id { get; private set; }

        [JsonProperty("media_type")]
        public string Type { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("landscape_image")]
        public JObject LandscapeImage { get; private set; }

        [JsonProperty("portrait_image")]
        public JObject PortraitImage { get; private set; }

        [JsonProperty("availability_notes")]
        public string AvailabilityNotes { get; private set; }

        [JsonProperty("complete")]
        public bool IsComplete { get; private set; }

        [JsonProperty("created")]
        public string CreatedAt { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("season")]
        public int SeasonIndex { get; private set; }

        #endregion Public Properties

        #region Public Methods

        public override string ToString()
        {
            return $"{Name}";
        }

        #endregion Public Methods
    }
}