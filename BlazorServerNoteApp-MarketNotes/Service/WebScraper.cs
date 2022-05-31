//https://www.c-sharpcorner.com/UploadFile/c63ec5/get-title-and-meta-description-of-live-url/
//http://books.toscrape.com/catalogue/category/books/mystery_3/index.html
//https://oxylabs.io/blog/csharp-web-scraping
//https://www.scrapingbee.com/blog/web-scraping-csharp/
//https://www.lambdatest.com/blog/scraping-dynamic-web-pages/


using BlazorServerNoteApp_MarketNotes.Model;
using HtmlAgilityPack;

namespace BlazorServerNoteApp_MarketNotes.Service
{
    public static class WebScraper
    {
        public static List<string> GetBookLinks(string url)
        {
            var bookLinks = new List<string>();
            HtmlDocument doc = GetDocument(url);
            HtmlNodeCollection linkNodes = doc.DocumentNode.SelectNodes("//h3/a");
            var baseUri = new Uri(url);
            foreach (var link in linkNodes)
            {
                string href = link.Attributes["href"].Value;
                bookLinks.Add(new Uri(baseUri, href).AbsoluteUri);
            }
            return bookLinks;
        }

        static HtmlWeb? web = new();
        // Parses the URL and returns HtmlDocument object
        static HtmlDocument GetDocument(string url)
        {
            //        HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);
            return doc;
        }

        public static string GetMetaTagValue(string url)
        {
            var txt = String.Empty;
            HtmlDocument doc = GetDocument(url);
            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//meta");

            if (nodes != null)
            {
                foreach (var item in nodes)
                {
                    if (item.Attributes["name"] != null && item.Attributes["content"] != null && item.Attributes["name"].Value == "description")
                    {

                        txt += item.Attributes["content"].Value + Environment.NewLine;
                        Console.WriteLine(item.Attributes["content"].Value);
                    }
                }
            }
            return txt;
        }

        public static MarketNote GetMetaValues(string url)
        {
            MarketNote note = new() { URL = url };
            HtmlDocument doc = GetDocument(url);
            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//meta");

            if (nodes != null)
            {
                foreach (var item in nodes)
                {
                    if (item.Attributes["name"] != null && item.Attributes["content"] != null)
                    {
                        //if (item.Attributes["name"].Value == "title") note.Title = item.Attributes["content"].Value + Environment.NewLine;
                        if (item.Attributes["name"].Value == "description") note.Description = item.Attributes["content"].Value + Environment.NewLine;
                    }
                }
            }
            //HtmlNode  n = doc.DocumentNode.SelectNodes("title").FirstOrDefault();
            HtmlNode n = doc.DocumentNode.SelectSingleNode("//title");
            if (n != null)
            {

                if (n.Name == "title")
                {
                    note.Title = n.InnerText;
                }
                Console.WriteLine(n.InnerText.ToString());
            }

            return note;
        }
    }
}
