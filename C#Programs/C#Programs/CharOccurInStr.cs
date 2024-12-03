using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    internal class CharOccurInStr
    {
        // PRINT NO OF CHARACTERS PRESENT IN THE STRING
        public void CharOccurance()
        {
            string s = "This is Madhumitha Marthala";
            Dictionary<String, int> charCount = new Dictionary<String, int>();
            for(int i= 0; i < s.Length; i++)
            {
                if (charCount.ContainsKey(s[i].ToString()))
                {
                    charCount[s[i].ToString()]++;
                }
                else
                {
                    charCount[s[i].ToString()] = 1;
                }
            }

            foreach(KeyValuePair<String,int> x in charCount)
            {
                Console.WriteLine(x.Key + " : " + x.Value);
            }
        }

        public void StringRev()
        {
            string s = "My class is this my name madhumitha";
            string rev = "";
            int x = 0;
            int y = 0;
            for (int i =0; i < s.Length; i++)
            {
                if (s[i].ToString() == " ")
                {
                     y = i-1;
                    for (int j = y; j >=x; j--)
                    {
                        rev += s[j];
                    }
                    x = i+1;
                    rev += " ";
                }  
            }
            for (int i = s.Length-1; i>=x; i--)
            {
                rev += s[i];
            }
            Console.WriteLine(rev);
        }

        public void UniqueChars()
        {
            string s = "Madhumitha";
            ArrayList stringList = new ArrayList();
            for(int i= 0;i < s.Length; i++)
            {
                if (stringList.Contains(s[i].ToString()))
                {
                    continue;
                }
                else
                {
                    stringList.Add(s[i].ToString());
                }
            }
            foreach(string k  in stringList)
            {
                Console.Write(k.ToString() + ", ");
            }
            Console.WriteLine();
        }

        public void NonRepeatChars()
        {
            //without dictionary
            string s = "Chinni Krishna Reddy";
            for(int i = 0;  i < s.Length; i++)
            {
                int c = 0;
                for(int j = 0; j < s.Length; j++)
                {
                    if (s[i].ToString().ToLower() == s[j].ToString().ToLower())
                    {
                        c++;
                    }
                }
                if(c == 1)
                {
                    Console.Write(s[i] + ", ");
                }
            }
            Console.WriteLine();

            //using dictionary
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for(int i = 0;i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i].ToString().ToLower()))
                {
                    dict[s[i].ToString().ToLower()]++;
                }
                else
                {
                    dict[s[i].ToString().ToLower()] = 1;
                }
            }
            foreach(KeyValuePair<string, int> kvp in dict)
            {
                if(kvp.Value == 1)
                {
                    Console.Write(kvp.Key + ", ");
                }
            }
            Console.WriteLine();
        }

        public void RevStringByWords()
        {
            string  s = "Banglore is a cool place";
            var words = s.Split(' ');
            string result = "";
            for(int i = 0; i < words.Length; i++)
            {
                //for(int j = words[i].Length-1; j >= 0; j--)
                //{
                    result += words[i];
                //}
                result += " ";
            }
            Console.WriteLine(result);

        }

        public void SubStringOfString()
        {
            string s = "abdhg";
            for(int i = 0; i < s.Length; i++)
            {
                string result = "";
                for(int j = i; j<s.Length; j++)
                {
                    result += s[j];
                    Console.WriteLine(result);
                }
            }
        }
    }
}
