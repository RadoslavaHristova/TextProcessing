/*
Linux, Windows
It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux! Sincerely, a Windows client

 */
namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text=Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                string replaced = ReplaceWithAsterisks(bannedWords[i]);

                int index = 0;
                while ((index = text.IndexOf(bannedWords[i])) > -1)
                {
                    text = text.Replace(bannedWords[i],replaced);
                }
            }
            Console.WriteLine(text);

        }
        public static string ReplaceWithAsterisks(string banned)
        {
            
            string asterisks = new string('*', banned.Length);

            return asterisks;
        }
    }
}