using System.ComponentModel;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPairs = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();
            for (int i = 0; i < numberOfPairs; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (synonyms.ContainsKey(word)) 
                {
                    synonyms[word].Add(synonym);
                }

                else 
                {
                    synonyms.Add(word, new List<string> {synonym});
                }

            }

            foreach (KeyValuePair<string, List<string>> pairs in synonyms)
                {
                Console.WriteLine($"{pairs.Key} - {string.Join(", ", pairs.Value)}");
            }



           



        }
    }
}