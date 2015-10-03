namespace _01.ProcessTelerikAcademyYoutubeRSSFeed
{
    using Newtonsoft.Json;

    internal class Link
    {
        [JsonProperty("@href")]
        public string Href { get; set; }
    }
}