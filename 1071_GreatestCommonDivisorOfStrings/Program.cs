namespace _1071_GreatestCommonDivisorOfStrings;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        var str1 = Console.ReadLine();
        var str2 = Console.ReadLine();
        
        Console.WriteLine(GcdOfStrings(str1, str2));
    }
    
    public static string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1)
            return "";
            
        int g = Gcd(str1.Length, str2.Length);
        return str1.Substring(0, g);
    }

    private static int Gcd(int a, int b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }
}