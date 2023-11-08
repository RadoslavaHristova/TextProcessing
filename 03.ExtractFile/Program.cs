namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            string[] name = input.Split('\\');
            string[] extension = input.Split('.');

            string fileName = name[name.Length - 1];
            int indexInName = fileName.IndexOf('.');
            
            Console.WriteLine($"File name: { fileName.Substring(0, indexInName)}");
            Console.WriteLine($"File extension: {extension[extension.Length-1]}");
            //C:\Internal\training-internal\Template.pptx

        }
    }
}