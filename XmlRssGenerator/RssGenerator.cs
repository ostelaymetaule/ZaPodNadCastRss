using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using XmlRssGenerator.RssModel;
namespace XmlRssGenerator
{
    /// <summary>
    /// The class generates a valid iTunes compatible xml rss feed
    /// </summary>
    public class RssGenerator
    {
         
        public RssFeed GetDummyPodcastFeed(string name)
        {
            var feeCastRss = new RssFeed()
            {
                Channel = new Channel()
                {
                    Owner = new Author()
                    {
                        Email = name + "@" + name + ".com",
                        Name = name + " author"
                    },
                    Link = new Link()
                    {
                        Linkhref = "localhost/mystuff"
                    },
                    Author = name,
                    Description = "Podcast from a good human " + name,
                    Summary = "Once apon a time " + name + " started a podcast",
                    Copyright = DateTime.Today.Year.ToString(),
                    Image = new PodcastImage()
                    {
                        ImageLink = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/668d6d05-b6a7-4bab-b1a0-3dd1927e166b/d5fz9d2-4d4bf36b-c098-4b4e-a01d-9bcf12b3130f.jpg/v1/fill/w_900,h_1083,q_75,strp/coffee_by_grafyth_d5fz9d2-fullview.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9MTA4MyIsInBhdGgiOiJcL2ZcLzY2OGQ2ZDA1LWI2YTctNGJhYi1iMWEwLTNkZDE5MjdlMTY2YlwvZDVmejlkMi00ZDRiZjM2Yi1jMDk4LTRiNGUtYTAxZC05YmNmMTJiMzEzMGYuanBnIiwid2lkdGgiOiI8PTkwMCJ9XV0sImF1ZCI6WyJ1cm46c2VydmljZTppbWFnZS5vcGVyYXRpb25zIl19.zNaXGntSPkvFm0bascEO1PVj8ypJHbGkOuh7gg_0FFM",
                        ImageUrl = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/668d6d05-b6a7-4bab-b1a0-3dd1927e166b/d5fz9d2-4d4bf36b-c098-4b4e-a01d-9bcf12b3130f.jpg/v1/fill/w_900,h_1083,q_75,strp/coffee_by_grafyth_d5fz9d2-fullview.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9MTA4MyIsInBhdGgiOiJcL2ZcLzY2OGQ2ZDA1LWI2YTctNGJhYi1iMWEwLTNkZDE5MjdlMTY2YlwvZDVmejlkMi00ZDRiZjM2Yi1jMDk4LTRiNGUtYTAxZC05YmNmMTJiMzEzMGYuanBnIiwid2lkdGgiOiI8PTkwMCJ9XV0sImF1ZCI6WyJ1cm46c2VydmljZTppbWFnZS5vcGVyYXRpb25zIl19.zNaXGntSPkvFm0bascEO1PVj8ypJHbGkOuh7gg_0FFM"
                    },
                    ItunesImage = new ItunesImage()
                    {
                        ImageUrl = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/i/668d6d05-b6a7-4bab-b1a0-3dd1927e166b/d5q4moc-c88bc1a2-5c8d-46e0-821d-3e37ec3e1789.png"
                    },
                    IsExplicit =   "Yes"  ,

                    ITunesCategory = new[] {
                        new Category()
                    {
                        CategoryText = "History"
                    },
                        new Category()
                    {
                        CategoryText =  "People",
                        Value = " ",
                    }
                    }
                   ,// "Society & Culture"
                    //ITunesSubCategory = "Places & Travel",
                    Language = "Russian",
                    Title = name,
                    Episodes = new List<Episode>()
                    {
                        new Episode()
                        {
                            Title="1. episode",
                            Duration = "1:40",
                            Guid = Guid.NewGuid().ToString(),
                            Summary ="The sample episode for a sample podcast",
                            IsExplicit = true,
                            IsExplicitItunes = "Yes",
                            TitleItunes = "1. episode itunes",
                            Item = new Enclosure()
                            {
                                FileLength = 100,
                                FileType = "mp3",
                                FileUrl = "http://localhost/1.mp3"
                            }
                        }
                    }
                    
                }
            };
            return feeCastRss;
        }
        //TODO: Method that takes a podcast object and generates a rss
        /// <summary>
        /// Serialize the podcast episodes als xml
        /// </summary>
        /// <returns></returns>
        public MemoryStream GenerateRss(RssFeed feed)
        {
            var rssFeedBuilder = new MemoryStream();



            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add(RssNamespaces.Itunes.Key, RssNamespaces.Itunes.Value);
            ns.Add(RssNamespaces.Atom.Key, RssNamespaces.Atom.Value);

            var serializer = new XmlSerializer(typeof(RssFeed));
            using (var w = XmlWriter.Create(rssFeedBuilder, new XmlWriterSettings()
            {
                Indent = true,
                Encoding = Encoding.UTF8
            }))
            {
                serializer.Serialize(w, feed, ns);
            }

            //var Duration = new TimeSpan(0, 0, new ATL.Track(Path.Combine(_rssSettings.AudioFilesRootDirectory, episodeInfos.FirstOrDefault().Filename)).Duration).ToString();
            //Use memorystream
            //"﻿<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
            return rssFeedBuilder;
        }


    }
}
