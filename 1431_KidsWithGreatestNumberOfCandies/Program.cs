namespace _1431_KidsWithGreatestNumberOfCandies;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        KidsWithCandies([2,3,5,1,3],3);
    }
    
    public static IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var maxCandies = candies.Max(); // with LINQ
        
        //var maxCandies_WithFor = candies[0];
        // foreach (var candy in candies)
        // {
        //     if (candy > maxCandies_WithFor)
        //     {
        //         maxCandies_WithFor = candy;
        //     }
        // }

        // for (int i = 1; i < candies.Length; i++)
        // {
        //     if (candies[i] > maxCandies_WithFor)
        //     {
        //         maxCandies_WithFor = candies[i];
        //     }
        // }
        //Console.WriteLine(maxCandies_WithFor);    
        
        IList<bool> result = new List<bool>();
        for (int i = 0; i < candies.Length; i++)
        {
            if(extraCandies + candies[i] >= maxCandies)
                result.Add(true);
            else
                result.Add(false); 
        }
        Console.WriteLine(string.Join(",", result));
        Console.WriteLine($"Max candies: {maxCandies}");
        return null;
    }
}