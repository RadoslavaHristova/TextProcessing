/*
helLo
Softuni
bottle
end
 */
internal class Program
    {
    static void Main(string[] args)
    {
        string command = "";
        while ((command = Console.ReadLine()) != "end")
        {
            Console.WriteLine($"{command} = {ReverseString(command)}");
        }
    }
        public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    
    }
