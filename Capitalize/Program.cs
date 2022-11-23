namespace Capitalize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = "bU tasKI metHodla yAzmAliSINiz";
            string str = Console.ReadLine();
            Console.WriteLine(Capitalize(str));
        }

        static string Capitalize(string str)
        {
            str = str.ToLower();
            string[] word = str.Split();
            string filteredWord = "";

            foreach (var item in word)
            {
                filteredWord += char.ToUpper(item[0]) + item.Substring(1) + " ";
            }
            return filteredWord;
        }

    }
}