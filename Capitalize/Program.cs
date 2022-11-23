namespace Capitalize
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = "bU tasKI metHodla yAzmAliSINiz";
            Capitalize(str);

        }

        static void Capitalize(string str)
        {
            str = str.ToLower();
            string[] word = str.Split();

            foreach (var item in word)
            {
                Console.Write(char.ToUpper(item[0]) + item.Substring(1) + " ");
            }
        }

    }
}