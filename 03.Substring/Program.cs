namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            string stringToRemoveFrom=Console.ReadLine() ;

            int index=0 ;
            while((index = stringToRemoveFrom.IndexOf(input)) > -1)
            {
           stringToRemoveFrom= stringToRemoveFrom.Remove(index,input.Length) ;
            }
            Console.WriteLine(stringToRemoveFrom) ;
        }
    }
}
/*
ice
kicegiciceeb

 
 */