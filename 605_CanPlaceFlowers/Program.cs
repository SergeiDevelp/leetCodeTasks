namespace _605_CanPlaceFlowers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var sol = new Solution();
        int[] flowerbed = [1, 0, 0, 0, 1];
        int n = 2;
        bool canPlant = sol.CanPlaceFlowers(flowerbed, n);
        
        Console.WriteLine(canPlant);
    }
}

public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (n == 0)
            return true; 
        int count = 0;
         
        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) &&
                (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
            {
                flowerbed[i] = 1;
                count++;
                if (count >= n)
                    return true;
            }
        }
        
        return false;
    }
}