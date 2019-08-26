using System.Xml.Serialization;

namespace XmlRssGenerator.RssModel
{
    public class Author
    {
        [XmlElement("name", Namespace = RssNamespaces.ItunesUri)]
        public string Name { get; set; }

        [XmlElement("email", Namespace = RssNamespaces.ItunesUri)]
        public string Email { get; set; }

    }
}