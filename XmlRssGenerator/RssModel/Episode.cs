using System;
using System.Xml.Serialization;
namespace XmlRssGenerator.RssModel
{
    public class Episode
    {
        [XmlElement("title", Namespace = RssNamespaces.ItunesUri)]
        public string TitleItunes { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }
        [XmlElement("subtitle", Namespace = RssNamespaces.ItunesUri)]
        public string SubTitleItunes { get; set; }

        [XmlElement("subtitle")]
        public string SubTitle { get; set; }
        [XmlElement("type", Namespace = RssNamespaces.ItunesUri)]
        public string episodeType { get; set; } = "full";

        [XmlElement("guid")]
        public string Guid { get; set; }

        [XmlElement("summary", Namespace = RssNamespaces.ItunesUri)]
        public string Summary { get; set; }

        [XmlElement("link")]
        public string Permalink { get; set; }

        [XmlElement("image", Namespace = RssNamespaces.ItunesUri)]
        public ItunesImage EpisodePic { get; set; }

        [XmlElement("duration")]
        public string Duration { get; set; }

        [XmlElement("keywords")]
        public string Keywords { get; set; }

        [XmlElement("pubDate")]
        public string PublicationDate { get; set; }

        [XmlElement("isExplicit")]
        public bool IsExplicit { get; set; }
        [XmlElement("explicit", Namespace = RssNamespaces.ItunesUri)]
        public string IsExplicitItunes { get; set; }

        [XmlElement("enclosure")]
        public Enclosure Item { get; set; }
    }
}