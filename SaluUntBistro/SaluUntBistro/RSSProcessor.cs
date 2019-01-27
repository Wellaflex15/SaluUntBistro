using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Xml;
using System.ServiceModel.Syndication;

namespace SaluUntBistro
{
    // TODO - Continue here test solution for RSS-feed -> want to use JSON -> and probably a static instance of this in some way. A class for the respose??

    public class RSSProcessor
    {
        static string url = "https://www.fazerfoodco.se/modules/MenuRss/MenuRss/CurrentWeek?costNumber=6434&language=sv";

        public List<string> GetRssFeed() {

            List<string> feedOfStrings = new List<string>();

            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            foreach (SyndicationItem item in feed.Items)
            {
                feedOfStrings.Add(item.Title.Text);
                feedOfStrings.Add(item.Summary.Text);
            }

            return feedOfStrings;
        }
    }
}
