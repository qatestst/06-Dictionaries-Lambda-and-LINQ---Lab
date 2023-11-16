using System.Security;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            
            foreach (string word in words) 
            {
                string caseInsensitiveWord = word.ToLower();

                if (wordsCount.ContainsKey(caseInsensitiveWord))
                {
                    wordsCount[caseInsensitiveWord]++;
                }
                else
                { 
                wordsCount.Add(caseInsensitiveWord, 1);
                }
            }

            foreach (KeyValuePair<string, int> keyPair in wordsCount) 
            {
                if(keyPair.Value %2 != 0) 
                {
                    Console.Write($"{keyPair.Key} ");
                }
            
            }
            
        }
    }
}