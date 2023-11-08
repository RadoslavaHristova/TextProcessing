using System.Text;

namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine()
                .Split()
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var word in inputArr)
            {
              for(int i=0;i<word.Length;i++)
                {
                    sb.Append(word);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}