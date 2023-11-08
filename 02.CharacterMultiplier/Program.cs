// Peter George  a aaaa
namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string first = input[0], second = input[1];
            int sum = 0;

            int length = Math.Max(first.Length, second.Length);

            for (int i = 0; i < length; i++) 
            {
            if (i < first.Length && i < second.Length) 
                {
                  sum+= first[i] * second[i];
                }

            else if(i < first.Length)
                { sum += first[i]; }

            else if (i < second.Length)
                { 
                sum += second[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}