namespace _151_ReverseWordsInaString;

class Program
{
    static void Main(string[] args)
    {
        var sol = new Solution();
        Console.WriteLine("Hello, World!");
        
        Console.WriteLine(sol.ReverseWords("a good   example"));
        
        //Output: "blue is sky the"
        //Input: s = "  hello world  "
        //Output: "world hello"
        //Input: s = "a good   example"
        //Output: "example good a"
    }
}

public class Solution {
    public string ReverseWords(string s)
    {
        // var str = s.Trim();
         string[] words = s.Split(' ',  StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
         Array.Reverse(words);
         return string.Join(" ", words);
         
        //запарился с этим алгоритмом на кучу строк, но работает так же как строчки выше.
        // bool inWord = false;
        // int start = 0 ;
        // char[] arr = s.ToCharArray();
        // Array.Reverse(arr);
        //
        // for (int i = 0; i <= arr.Length; i++)
        // {
        //     if (i < arr.Length && arr[i] != ' ' && !inWord)
        //     {
        //         start = i;
        //         inWord = true;
        //     }
        //         
        //     if(inWord && (i == arr.Length || arr[i] == ' '))
        //     {
        //         int end = i  - 1;
        //         while (start < end)
        //         {
        //             char temp = arr[start];
        //             arr[start] = arr[end];
        //             arr[end] = temp;
        //             start++;
        //             end--;
        //         }
        //
        //         inWord = false;
        //     }
        // }
        // int trimStart = 0;
        // int trimEnd   = arr.Length - 1;
        // int write = 0;
        //
        // while (trimStart < arr.Length && char.IsWhiteSpace(arr[trimStart]))
        //     trimStart++;
        // while (trimEnd >= 0 && char.IsWhiteSpace(arr[trimEnd]))
        //     trimEnd--;
        //
        // if (trimStart > trimEnd)
        //     return "";
        //
        // for (int read = trimStart; read <= trimEnd; read++)
        // {
        //     if (arr[read] != ' ')
        //     {
        //         arr[write++] = arr[read];
        //     }
        //     else if (write > 0 && arr[write-1] != ' ')
        //     {
        //         arr[write++] = ' ';
        //     }
        // }
        //
        // return new string(arr, 0, write);
    }
}