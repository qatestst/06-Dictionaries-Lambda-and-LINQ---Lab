namespace _04._Word_Filter___01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 4, 6, 8, 54, 34};
            var result = numbers.Where(x => x > 9);
            Console.WriteLine(string.Join(", ", result));


            List<string> numbers1 = new List<string> { "1", "344", "22", "100"};
            var result1 = numbers1.Where(x => x.Length >2);
            Console.WriteLine(string.Join(", ", result1));
        }
    }
}