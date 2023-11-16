namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            SortedDictionary<int, int> numbers = new SortedDictionary<int, int>();

            foreach (int i in input)
            {
                if (numbers.ContainsKey(i))
                { numbers[i]++;

                }
                else 
                {
                numbers.Add(i, 1);
                }
            }

            foreach (KeyValuePair<int, int> number in numbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
           
            
        }
    }
}