//Agd#53Dfg^&4F53
namespace _05.Digits_LettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach(char c in input) 
            { 
            if (char.IsDigit(c))
            { 
                    Console.Write(c);
            }
            }
            Console.WriteLine();
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    Console.Write(c);
                }
            }
            Console.WriteLine();
            foreach (char c in input)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    Console.Write(c);
                }
            }
        }
    }
}