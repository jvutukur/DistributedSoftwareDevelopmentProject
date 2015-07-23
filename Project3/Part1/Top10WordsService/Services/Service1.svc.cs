using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using System.Text.RegularExpressions;

namespace Services
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
            List<String> wordList=contentAtGivenUrl.Split(' ').ToList(); // splitting words based on white spaces


            //Making a dictionary for the wordList            
            Dictionary<string,int> wordListDict=new Dictionary<String,int>();            
            foreach(String word in wordList)
            {
                if (wordListDict.ContainsKey(word))
                    wordListDict[word]++;
                else
                    wordListDict.Add(word,1);
            }


            //Sorting the dictionary in desecding order
            var orderedDict=wordListDict.OrderBy(t=>t.Value);

            //Taking top 10 words from sorted dictionary
            top10Words = new String[10];
            int count=0;
            foreach(KeyValuePair<String,int> keyValuePair in orderedDict)
            {
             if(count<10)
             {
                 top10Words[count]=keyValuePair.Key;
                 count++;
             }
            }
        }
            catch(Exception e)
            {

            }
                return top10Words;
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
