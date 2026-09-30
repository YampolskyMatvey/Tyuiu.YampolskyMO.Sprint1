using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.YampolskyMO.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            string[] words = value.Split(' ');
            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    string word = words[i];
                    string modified = word[word.Length - 1] + word.Substring(0, word.Length - 1);
                    result += modified;
                    if (i < words.Length - 1)
                    {
                        result += " ";
                    }
                }
            }
            return result;
        }
    }
}