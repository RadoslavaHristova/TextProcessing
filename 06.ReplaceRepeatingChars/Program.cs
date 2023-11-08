namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[]input=Console.ReadLine().ToArray();
            List<char> output = new List<char>();
            output.Add(input[0]);
            for (int i = 1; i < input.Length; i++) 
            {
                if (input[i] != input[i-1])
                { output.Add(input[i]); }
                
            }
            Console.WriteLine(string.Join("",output));
            //aaaaabbbbbcdddeeeedssaa
            //qqqwerqwecccwd
        }
    }
}