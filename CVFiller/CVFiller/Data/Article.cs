using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FormFiller.Data
{
    class Article
    {
        public Article(string key, string value, List<string> hashTags)
        {
            Key = key;
            Value = value;
            HashTags = hashTags;
            ShortenedKey = GetShortenedKey(key);
        }

        public static string GetShortenedKey(string key)
        {
            key = Regex.Replace(key, @"\s+", " ");
            var items = key.Split(' ');
            string shortenedKey = string.Empty;
            foreach (var word in items)
            {
                shortenedKey += word.Substring(0, 1);
            }
            return shortenedKey;
        }

        public string Key { get; set; }
        public string Value { get; set; }
        public List<string> HashTags { get; set; }
        public string ShortenedKey { get; set; }
    }
}
