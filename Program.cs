namespace LinqElementOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 5, 1, 8, 5 };

            var elements = numbers.Where(c => c > 90).DefaultIfEmpty(50);

            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }
        }
    }
}
