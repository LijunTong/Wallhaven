using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallHavenGetter.Models
{
    public partial class ImgResult
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("short_url")]
        public Uri ShortUrl { get; set; }

        [JsonProperty("uploader")]
        public Uploader Uploader { get; set; }

        [JsonProperty("views")]
        public long Views { get; set; }

        [JsonProperty("favorites")]
        public long Favorites { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("purity")]
        public string Purity { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("dimension_x")]
        public long DimensionX { get; set; }

        [JsonProperty("dimension_y")]
        public long DimensionY { get; set; }

        [JsonProperty("resolution")]
        public string Resolution { get; set; }

        [JsonProperty("ratio")]
        public string Ratio { get; set; }

        [JsonProperty("file_size")]
        public long FileSize { get; set; }

        [JsonProperty("file_type")]
        public string FileType { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("path")]
        public Uri Path { get; set; }

        [JsonProperty("thumbs")]
        public Thumbs Thumbs { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }
    }

    public partial class Tag
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("category_id")]
        public long CategoryId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("purity")]
        public string Purity { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
    }


    public partial class Uploader
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("avatar")]
        public Dictionary<string, Uri> Avatar { get; set; }
    }
}
