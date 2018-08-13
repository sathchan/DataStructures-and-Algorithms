using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class TinyUrl
    {
        Dictionary<string, string> urlDict = new Dictionary<string, string>();

        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {
            var hash = Math.Abs(longUrl.GetHashCode()).ToString();            
            if (!urlDict.ContainsKey(hash))
            {
                urlDict.Add(hash, longUrl);
            }

            return "http://tinyurl.com/" + hash;
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            shortUrl = shortUrl.Replace("http://tinyurl.com/", string.Empty);

            if (urlDict.ContainsKey(shortUrl))
            {
                string origUrl;
                urlDict.TryGetValue(shortUrl, out origUrl);

                return origUrl;
            }

            

            return string.Empty;
        }
    }
}
