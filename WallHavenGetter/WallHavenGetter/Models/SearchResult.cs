using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallHavenGetter.Models
{
    public partial class SearchResult
    {
        [JsonProperty("data")]
        public Datum[] Data { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

    public partial class Datum
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

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
        public string Path { get; set; }

        [JsonProperty("thumbs")]
        public Thumbs Thumbs { get; set; }
    }

    public partial class Thumbs
    {
        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }
    }

    public partial class Meta
    {
        [JsonProperty("current_page")]
        public long CurrentPage { get; set; }

        [JsonProperty("last_page")]
        public long LastPage { get; set; }

        [JsonProperty("per_page")]
        public long PerPage { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("query")]
        public object Query { get; set; }

        [JsonProperty("seed")]
        public object Seed { get; set; }
    }
}
