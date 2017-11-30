using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using SQLite;
using System.IO;


namespace Shared
{
    public class Bing
    {
        private class Dictionaries
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }
            [Unique]
            public string Word { get; set; }
            public string Content { get; set; }
        }
        HttpClient _client;
        private static Bing sBing;
        SQLiteConnection _db;
        public Bing()
        {
            _client = new HttpClient(new HttpClientHandler
            {
                UseProxy = false,
            });
            var databasePath = Path.Combine(Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]), "dictionaries.db");

            _db = new SQLiteConnection(databasePath);
            _db.CreateTable<Dictionaries>();
        }

        public async void ChineseToEnglishFromClipboard()
        {
            var v = Clipboard.GetText().Trim().ToLower();
            var r = _db.Query<Dictionaries>("select * from Dictionaries where Word=?", new object[] { v });
            if (r .Count!=0)
            {
                Clipboard.SetText(r[0].Content);
                return;
            }
            var url = "https://cn.bing.com/dict/search?q=";

            var res = await _client.GetAsync(url + v);
            var htmlContent = await res.Content.ReadAsStringAsync();

            var hd = new HtmlAgilityPack.HtmlDocument();
            hd.LoadHtml(htmlContent);

            var def = hd.DocumentNode.SelectSingleNode("//*[@class=\"def\"]");
            if (def.InnerText.Trim().Length != 0)
            {
                _db.Insert(new Dictionaries
                {
                    Word = v.ToLower(),
                    Content = def.InnerText.Trim()
                });
            }
            Clipboard.SetText(def.InnerText);
        }
        public static Bing Instance()
        {
            if (sBing == null)
            {
                sBing = new Bing();
            }
            return sBing;
        }
    }
}
