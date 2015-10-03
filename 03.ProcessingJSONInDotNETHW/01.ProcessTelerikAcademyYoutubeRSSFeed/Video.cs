using System.Runtime.CompilerServices;

namespace _01.ProcessTelerikAcademyYoutubeRSSFeed
{
    using Newtonsoft.Json;

    internal class Video
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("yt:videoId")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public Link Link { get; set; }

        public override string ToString()
        {
            return "Title: " + this.Title + ", id: " + this.Id + ", link: " + this.Link.Href;
        }
    }
}