namespace _605_CanPlaceFlowers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Task 605 is done. I used a greedy algorithm.");
        var sol = new Solution();
        int[] flowerbed = [1, 0, 0, 0, 1];
        int n = 1;
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