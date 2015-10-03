namespace _01.ProcessTelerikAcademyYoutubeRSSFeed
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Xml.Linq;

    internal class Program
    {
        private const string rssXMLOutputFile = "../../rssXMLOutput.xml";
        private const string rssSource = "https://www.youtube.com/feeds/videos.xml?user=TelerikAcademy";
        private const string videoAsHTML = "../../videos.html";

        private static void Main(string[] args)
        {
            DownloadRSSFeed(rssSource, rssXMLOutputFile);
            XDocument doc = XDocument.Load(rssXMLOutputFile);
            string rssAsJson = JsonConvert.SerializeXNode(doc);

            var titles = GetAllVideoTitlesFromJSON(rssAsJson);
            Console.WriteLine(string.Join(Environment.NewLine, titles));
            Console.WriteLine();
            var videos = GetAllVideosFromJSON(rssAsJson);
            Console.WriteLine(string.Join(Environment.NewLine, videos));
            var htmlPage = GenerateHtml(videos);
            File.WriteAllText(videoAsHTML, htmlPage, Encoding.UTF8);
        }

        private static string GenerateHtml(IEnumerable<Video> items)
        {
            var sb = new StringBuilder();
            sb.AppendLine("<!DOCTYPE html><html><body><ul>");

            foreach (var item in items)
            {
                sb.AppendFormat("<li style=\"list-style-type:none;\"><a href=\"{0}\"><strong>{1}</strong></a></li>", item.Link.Href, item.Title);
                sb.AppendFormat("<iframe width=\"420\" height=\"315\" src=\"http://www.youtube.com/embed/{0}?autoplay=1\"></iframe>", item.Id);
            }

            sb.AppendLine("</ul></body></html>");

            return sb.ToString();
        }

        private static IEnumerable<Video> GetAllVideosFromJSON(string rssJSONFeed)
        {
            var jsonRSSObj = JObject.Parse(rssJSONFeed);
            var extractedVideos = jsonRSSObj["feed"]["entry"].Select(v => JsonConvert.DeserializeObject<Video>(v.ToString()));

            return extractedVideos;
        }

        private static IEnumerable<JToken> GetAllVideoTitlesFromJSON(string RSSFeedJSON)
        {
            var jsonRSSObj = JObject.Parse(RSSFeedJSON);
            var titles = jsonRSSObj["feed"]["entry"].Select(e => e["title"]);

            return titles;
        }

        private static void DownloadRSSFeed(string rssSource, string rssXMLOutputFile)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(rssSource, rssXMLOutputFile);
            }
        }
    }
}