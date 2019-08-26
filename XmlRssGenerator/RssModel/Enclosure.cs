using System.Xml.Serialization;
namespace XmlRssGenerator.RssModel
{
    public class Enclosure
    {
        [XmlAttribute("url")]
        public string FileUrl { get; set; }
        /// <summary>
        /// the path to the file on the drive relative to RssFeed.PathToPodcastDirectory 
        /// </summary>
        [XmlIgnore]
        public string RelativeFilePath { get; set; }

        [XmlAttribute("length")]
        public int FileLength { get; set; }

        [XmlAttribute("type")]
        public string FileType { get; set; } = @"audio/mpeg";
    }
}