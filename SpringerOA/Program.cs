using System;
using System.IO;
using System.Net;
using System.Collections;
using System.Collections.Generic;


namespace SpringerOA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------ Begin ------------------");
            List<Tuple<string, string>> searchResults = ReadSearchResultsCSV("SearchResults.csv");
            string fileName, url;
            foreach (Tuple<string, string> fileTuple in searchResults)
            {
                using (var client = new WebClient())
                {
                    url = getBookURL(fileTuple.Item2);
                    fileName = getFileName(fileTuple.Item1);
                    if(string.IsNullOrWhiteSpace(url) || string.IsNullOrWhiteSpace(fileName)) continue;
                    client.DownloadFile(url,fileName);
                    Console.WriteLine(url + "----->" + fileName);
                }
            }
            Console.WriteLine("------------------ End ------------------");
        }

        public static List<Tuple<string, string>> ReadSearchResultsCSV(string searchResultsFileName)
        {
            List<Tuple<string, string>> result = new List<Tuple<string, string>>();
            using (var reader = new StreamReader(searchResultsFileName))
            {
                reader.ReadLine(); // Skip column headers
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    result.Add(new Tuple<string, string> (values[0], values[8]));
                }
            }
            return result;
        }

        // Convert  https://link.springer.com/book/10.1007/978-3-030-20024-4 from csv
        // To       https://link.springer.com/content/pdf/10.1007%2F978-3-030-20024-4.pdf
        public static string getBookURL(string rawURL)
        {
            try{
            Console.WriteLine(rawURL);
            rawURL = rawURL.Replace("book", "content/pdf");
            rawURL = rawURL.Substring(0, rawURL.LastIndexOf("/")) + "%2f" + rawURL.Substring(rawURL.LastIndexOf("/") + 1) + ".pdf";
            rawURL = rawURL.Replace("\"","");
            Console.WriteLine(rawURL);
            return rawURL;
            } catch{ return "";}
        }

        public static string getFileName(string rawFileName)
        {
            try{
            rawFileName = rawFileName.Replace("\"","");
            rawFileName = rawFileName + ".pdf";
            return rawFileName;
            }catch { return "";}
        }
    }
}
