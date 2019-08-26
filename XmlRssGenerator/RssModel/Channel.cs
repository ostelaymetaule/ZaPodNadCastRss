using System.Xml.Serialization;
using System.Collections.Generic;
using System;

namespace XmlRssGenerator.RssModel
{
    public class Channel
    {
        [XmlElement("title")]

        public string Title { get; set; }
        [XmlElement("subtitle")]

        public string SubTitle { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("summary", Namespace = RssNamespaces.ItunesUri)]
        public string Summary { get; set; }

        [XmlIgnore]
        public Link Link { get; set; } = new Link();

        [XmlElement("owner", Namespace = RssNamespaces.ItunesUri)]
        public Author Owner { get; set; }

        [XmlElement("author", Namespace = RssNamespaces.ItunesUri)]
        public string Author { get; set; }
        [XmlElement("copyright")]

        public string Copyright { get; set; }
        [XmlElement("language")]

        public string Language { get; set; }

        [XmlElement("image", Namespace = RssNamespaces.ItunesUri)]
        public ItunesImage ItunesImage { get; set; }

        [XmlElement("image")]
        public PodcastImage Image { get; set; }

        [XmlElement("lastBuildDate")]
        public string LastBuildDate { get; set; } = DateTime.Now.ToString("r");

        //public int ImageWidth { get; set; }

        //public int ImageHeight { get; set; }

        [XmlElement("categories")]

        public List<string> Categories { get; set; } = new List<string>() { "podcast" };

        [XmlElement("category", Namespace = RssNamespaces.ItunesUri)]
        public Category[] ITunesCategory { get; set; }

        [XmlElement("itunessubcategory", Namespace = RssNamespaces.ItunesUri)]

        public string ITunesSubCategory { get; set; }
        [XmlElement("explicit", Namespace = RssNamespaces.ItunesUri)]
        public string IsExplicit { get; set; } = "No";

        [XmlElement("item")]
        public List<Episode> Episodes { get; set; }
    }
}