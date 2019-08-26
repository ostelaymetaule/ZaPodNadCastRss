using System.Xml.Serialization;
namespace XmlRssGenerator.RssModel
{
    public class ItunesImage
    {
        [XmlAttribute("href")]
        public string ImageUrl { get; set; }
    }
}