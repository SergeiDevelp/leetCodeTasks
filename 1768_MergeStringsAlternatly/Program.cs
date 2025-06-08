using System.Text;

namespace _1768_MergeStringsAlternatly;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your string: ");
        string world1 = Console.ReadLine();
        Console.WriteLine("Enter your string: ");
        string world2 = Console.ReadLine();
        Console.WriteLine(MergeAlternately(world1, world2));
        //MergeAlternately(world1, world2);

    }
    
    public static string MergeAlternately(string word1, string word2)
    {
        var sb = new StringBuilder();
        var minLength = Math.Min(word1.Length, word2.Length);

        for (int k = 0; k < minLength; k++)
        {
            sb.Append(word1[k]);
            sb.Append(word2[k]);
        }

        if (word1.Length > minLength)
        {
            sb.Append(word1.Substring(minLength));
        }
        else if (word2.Length > minLength)
        {
            sb.Append(word2.Substring(minLength));
        }
        
        return sb.ToString();
    }
}