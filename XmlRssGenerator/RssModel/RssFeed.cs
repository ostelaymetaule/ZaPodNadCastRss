using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XmlRssGenerator.RssModel
{
    [XmlRoot("rss")]
    public class RssFeed
    {
        [XmlAttribute("version")]
        public string Version { get; set; } = "2.0";
        [XmlElement("channel")]
        public Channel Channel { get; set; }

        /// <summary>
        /// the physical path to the directory containing all the podcast files
        /// </summary>
        [XmlIgnore]
        public string PathToPodcastDirectory { get; set; }
        

    }
}
