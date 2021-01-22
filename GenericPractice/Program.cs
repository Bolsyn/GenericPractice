using System;
using System.Collections.Generic;

namespace GenericPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Вот дом, Который построил Джек. А это пшеница, Кото­рая в темном  чулане хранится В доме, Который построил Джек. А это веселая птица­ синица, Которая часто вору­ет пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";
            string[] words = text.Split(' ');

            Dictionary<string, int> statistic = new Dictionary<string, int>();
            
            for(int i = 0; i < words.Length; i++)
            {
                if (!statistic.ContainsKey(words[i]))
                    statistic.Add(words[i], 1);
                else statistic[words[i]] += 1;
            }
            int count = 1;
            foreach(KeyValuePair<string,int> keyValue in statistic)
            {
                Console.WriteLine(count + "     " + keyValue.Key + "      " + keyValue.Value);
                count++;
            }

            Console.WriteLine("Всего слов: " +words.Length + ", Их которых уникальных: " + statistic.Count);
        }
    }
}
