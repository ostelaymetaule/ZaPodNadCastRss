using System.Xml.Serialization;

namespace XmlRssGenerator.RssModel
{
    public class Category
    {
        [XmlAttribute("text")]
        public string CategoryText { get; set; }

        [XmlText]
        public string Value { get; set; }

    }
}