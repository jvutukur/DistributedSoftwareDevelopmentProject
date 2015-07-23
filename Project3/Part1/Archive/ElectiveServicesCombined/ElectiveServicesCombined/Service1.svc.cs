using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;

using System.Net;
using System.IO;
namespace ElectiveServicesCombined
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {


        public String[] Top10Words(String url)
        {
            String[] top10Words = null;
            System.Net.WebClient webClient = new System.Net.WebClient();
            try
            {
                String contentAtGivenUrl = webClient.DownloadString(url); //retriving the content in the web page

                //Removing unwaned words, White spaces and special symbols in the content in the webpage
                contentAtGivenUrl = Regex.Replace(contentAtGivenUrl, "<[^>]*>", ""); // Angular brackets and content in between tags are deleted           


                //Making a list of words based on some delimiters ; : ( ) [ ] { } , = \ /. ? + - > < # &

                contentAtGivenUrl = Regex.Replace(contentAtGivenUrl, @"(;)|(,)|(:)|(\()|(\))|(\[)|(\])|(\{)|(\})|(=)|(\\)|(\/)|(\.)|(\?)|(\+)|(\-)|(\>)|(\<)|(\#)|(\&)", " "); //replacing all delimiters with white space
                contentAtGivenUrl = Regex.Replace(contentAtGivenUrl, @"\s+", " "); //Replacing more than one white space with single white space
                List<String> wordList = contentAtGivenUrl.Split(' ').ToList(); // splitting words based on white spaces


                //Making a dictionary for the wordList            
                Dictionary<string, int> wordListDict = new Dictionary<String, int>();
                foreach (String word in wordList)
                {
                    if (wordListDict.ContainsKey(word))
                        wordListDict[word]++;
                    else
                        wordListDict.Add(word, 1);
                }


                //Sorting the dictionary in desecding order
                var orderedDict = wordListDict.OrderBy(t => t.Value);

                //Taking top 10 words from sorted dictionary
                top10Words = new String[10];
                int count = 0;
                foreach (KeyValuePair<String, int> keyValuePair in orderedDict)
                {
                    if (count < 10)
                    {
                        top10Words[count] = keyValuePair.Key;
                        count++;
                    }
                }
            }
            catch (Exception e)
            {

            }
            return top10Words;



















        }




        public String[] NewsFocus(String topics)
        {
            String[] links = new String[25];


            String url = "https://www.google.com/webhp?sourceid=chrome-instant&ion=1&espv=2&ie=UTF-8#q=" + topics;

            //get all the content in the webpage

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            String content = sr.ReadToEnd();
            sr.Close();


            //taking out required content            
            string HRefurl = "href=(?:\"(?<URL>[^\"]*)\")";
            Match m = Regex.Match(content, HRefurl);
            String each;
            int count = 0;
            while (m.Success && count < 10)
            {
                each = m.Groups["URL"].ToString();
                //if (each.StartsWith("http")& !each.Contains("google"))
                if (each.StartsWith("http") && !each.Contains("css"))
                {
                    links[count] = each;
                    count++;
                }
                m = m.NextMatch();
            }


            url = "http://www.foxnews.com/search-results/search?q=arizona" + topics;
            System.Net.WebClient webClient = new System.Net.WebClient();
            content = webClient.DownloadString(url); //content contains all the data in foxnews search page

            m = Regex.Match(content, HRefurl);
            while (m.Success && count < 20)
            {
                each = m.Groups["URL"].ToString();
                if (each.StartsWith("http") && !each.Contains("css"))
                {
                    links[count] = each;
                    count++;
                }
                m = m.NextMatch();
            }


            url = "http://abcnews.go.com/search?searchtext=arizona" + topics;
            content = webClient.DownloadString(url);
            m = Regex.Match(content, HRefurl);
            while (m.Success && count < 25)
            {
                each = m.Groups["URL"].ToString();
                if (each.StartsWith("http") && !each.Contains("css"))
                {
                    links[count] = each;
                    count++;
                }
                m = m.NextMatch();
            }


            return links;
        }

    }
}
