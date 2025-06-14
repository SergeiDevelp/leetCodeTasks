namespace _345_ReverseVowelsOfaString;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var s = "IceCreAm";
        var sol = new Solution();
        //sol.ReverseVowels(s);
        Console.WriteLine(sol.ReverseVowels(s));
        Console.WriteLine("Test");
    }
}

public class Solution {
    public string ReverseVowels(string s) {
        var vowels = new HashSet<char> {'a','e','i','o','u','A','E','I','O','U'};
        char[] sCharsArray = s.ToCharArray();
        int left = 0, right = sCharsArray.Length - 1;

        while (left < right)
        {
            while (left < right && !vowels.Contains(sCharsArray[left]))
                left++;
            
            while (left < right && !vowels.Contains(sCharsArray[right]))
                right--;
            
            char temp = sCharsArray[left];
            sCharsArray[left] = sCharsArray[right];
            sCharsArray[right] = temp;
            left++;
            right--;
        }
       
        
        return new string(sCharsArray);

    }
}