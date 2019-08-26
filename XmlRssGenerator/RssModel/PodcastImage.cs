using System.Xml.Serialization;

namespace XmlRssGenerator.RssModel
{
    public class PodcastImage
    {
        [XmlElement("url")]
        public string ImageUrl { get; set; }

        [XmlElement("title")]
        public string ImageTitle { get; set; }

        [XmlElement("link")]
        public string ImageLink { get; set; }

    }
}