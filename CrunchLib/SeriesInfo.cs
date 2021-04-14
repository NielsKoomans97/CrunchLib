using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CrunchLib
{
    public class SeriesInfo
    {
        #region Public Properties

        [JsonProperty("series_id")]
        public long Id { get; private set; }

        [JsonProperty("media_type")]
        public string Type { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("landscape_image")]
        public JObject LandscapeImage { get; private set; }

        [JsonProperty("portrait_image")]
        public JObject PortraitImage { get; private set; }

        [JsonProperty("url")]
        public string Url { get; private set; }

        #endregion Public Properties
    }
}