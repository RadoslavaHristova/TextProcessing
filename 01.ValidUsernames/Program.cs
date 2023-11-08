namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ")
                .ToArray();

            for(int i = 0; i < usernames.Length; i++) 
            { 
            if (usernames[i].Length<3 || usernames[i].Length>16)
                { continue; }
                bool isValidUsername = usernames[i]
                    .All(c => char.IsLetterOrDigit(c) || c == '_' || c == '-');
                if(isValidUsername)
                { Console.WriteLine(usernames[i]); }
            }
        }
    }
}