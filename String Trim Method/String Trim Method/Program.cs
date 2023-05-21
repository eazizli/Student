internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Trim("   Fidan   Novrulu  "));
    }

    static string Trim(string word)
    {
        string result = "";
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] != ' ')
            {
                result += word[i];
                if (word[i+1]==' ')
                {
                    result += ' ';
                }
             
            }
        }
        return result;
    }
}