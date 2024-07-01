internal class Program
{
    static bool IsUnique(string str)
    {
        for(int i = 0; i < str.Length; ++i)
        {
            for(int j = i + 1; j < str.Length; ++j)
            {
                if(str[i] == str[j])
                {
                    return false;
                }
            }
        }

        return true;
    }

    static int AsciiSum(string str)
    {
        int sum = 0;
        foreach(char c in str)
        {
            sum += c;
        }

        return sum;
    }

    static bool IsStringValid(string str)
    {
        return str.Length >= 5 && str.Length <= 7 && str.All(char.IsAsciiLetterUpper) && IsUnique(str) && AsciiSum(str) >= 420 && AsciiSum(str) <= 600;
    }
    
    static void Main()
    {
        string str = string.Empty;
        bool isFirstTime = true;
        while(!IsStringValid(str))
        {
            if(!isFirstTime)
            {
                Console.WriteLine("String invalid!");
            }
            isFirstTime = false;
            Console.WriteLine("Please input a valid string.");
            str = Console.ReadLine() ?? string.Empty;
        }

        Console.WriteLine("String Valid!");
    }
}