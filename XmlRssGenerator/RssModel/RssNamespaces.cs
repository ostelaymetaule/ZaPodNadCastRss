using System.Collections.Generic;
namespace XmlRssGenerator.RssModel
{
    public static class RssNamespaces
    {
        public static KeyValuePair<string, string> Atom { get; } = new KeyValuePair<string, string>("atom", "http://www.w3.org/2005/Atom");
        public static KeyValuePair<string, string> Itunes { get; } = new KeyValuePair<string, string>("itunes", "http://www.itunes.com/dtds/podcast-1.0.dtd");
        public const string AtomName = @"atom";
        public const string ItunesName = @"itunes";
        public const string ItunesUri = @"http://www.itunes.com/dtds/podcast-1.0.dtd";

    }
}