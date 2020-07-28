using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using HtmlAgilityPack;
using System.IO;
using System.Threading;


namespace ScreenyScraper
{
    class Scraper
    {
        int _digits = 2;
        WebClient _webClient;
        string _firstLetter = "a";
        string _secondLetter = "a";
        Form1 _formReference;
        string _urlSuffix;


        public async void StartScrape(Form1 form)
        {
            _formReference = form;

            _webClient = new WebClient();
            _webClient.Proxy = null;

            await Task.Factory.StartNew(() => InitScrapeLoop(),
                                TaskCreationOptions.LongRunning);
        }

        void InitScrapeLoop()
        {
            while (_digits != 9999)
            {
                LoadImage();
                _digits++;
            }
        }

        void LoadImage()
        {
            try
            {
                byte[] bytes = _webClient.DownloadData(ScrapeImageData());
                MemoryStream ms = new MemoryStream(bytes);
                Image img = Image.FromStream(ms);

                _formReference.AddImageToUI(img, _urlSuffix);
            }
            catch
            {
                return;
            }
        }

        string ScrapeImageData()
        {
            GetUrlSuffix();
            string url = "https://prnt.sc/" + _urlSuffix;
            _webClient.Headers.Add("user-agent", "ASP.NET WebClient");
            String htmlCode = _webClient.DownloadString(url);

            var htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(htmlCode);

            var list = htmlDoc.DocumentNode.SelectNodes("//meta");

            foreach (var node in list)
            {
                if (node.GetAttributeValue("name", "") == "twitter:image:src")
                {
                    string content = node.GetAttributeValue("content", "");

                    return content;
                }

            }

            return "";
        }

        string GetUrlSuffix()
        {
            string zeroes = String.Concat(Enumerable.Repeat("0", 4 - _digits.ToString().Length));
            Console.WriteLine(_firstLetter + _secondLetter + zeroes + _digits.ToString());
            _urlSuffix = _firstLetter + _secondLetter + zeroes + _digits.ToString();
            return _urlSuffix;
        }
    }
}
