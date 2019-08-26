using System.Xml.Serialization;

namespace XmlRssGenerator.RssModel
{
    //    <atom:linkhref="http://www.files.idrsolutions.com/podcast.rss"
    //rel="self"
    //type="application/rss+xml" />


    public class Link
    {
        [XmlAttribute("linkhref", Namespace = RssNamespaces.AtomName)]
        public string Linkhref { get; set; } = @"self";
        [XmlAttribute("rel")]
        public string Rel { get; set; } = @"self";
        [XmlAttribute("type")]
        public string Type { get; set; } = @"application/rss+xml";

    }
}