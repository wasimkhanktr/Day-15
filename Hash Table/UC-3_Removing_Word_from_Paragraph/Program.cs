using Hash_Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Hash_Tables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sentenceWords;
            string sentence = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            //Breaking sentence in words & storing in array by split method.
            sentenceWords = sentence.Split(' ');
            checkingFrequencyOfWords(sentenceWords);
        }
        public static void checkingFrequencyOfWords(string[] sentenceWords)
        {
            MyMapNode<string, int> MyMapNode = new MyMapNode<string, int>(5);
            //Adding words with their count by checking with "CHECKWORD" Function.
            foreach (string word in sentenceWords)
            {
                int count = MyMapNode.CheckWord(word);
                //Count value using as a Value Pair while adding.
                MyMapNode.Add(word, count);
            }
            //For fetching unique items in array.
            IEnumerable<string> uniqueWords = sentenceWords.Distinct<string>();
            //Removing "Avoidable" Word of the sentence from the Hash Table.
            MyMapNode.Remove("avoidable");
            foreach (string word in uniqueWords)
            {
                int frequencyOfWord = MyMapNode.Get(word);
                Console.WriteLine($"\"{word}\"comes {frequencyOfWord} times");
            }
        }
    }
}
