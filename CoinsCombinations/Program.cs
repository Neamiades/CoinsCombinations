using System;
namespace CoinsCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 200;
            int[] coinsArr = { 1, 2, 5, 10, 20, 50, 100, 200 };
            ulong WaysNum = GetCombinationsNum(coinsArr, coinsArr.Length - 1, amount);
            Console.WriteLine($"Collecting an amount of {amount} pence via " +
                $"{{{string.Join(", ", coinsArr)}}} plurality of coins possible in so many ways: {WaysNum}");
        }
        /// <summary>
        /// Calculates recursively the number of ways to compile the sum of pence
        /// </summary>
        /// <param name="arr">A plurality of coin denominations</param>
        /// <param name="arrMax">The index of the maximum current plurality element</param>
        /// <param name="sum">Required amount</param>
        /// <returns>Number of ways to calculate the amount</returns>
        static ulong GetCombinationsNum(int[] arr, int arrMax, int sum)
        {
            if (sum == 0)
                return 1;
            if (sum <  0 || arrMax < 0)
                return 0;
            return GetCombinationsNum(arr, arrMax, sum - arr[arrMax]) + GetCombinationsNum(arr, --arrMax, sum);
        }
    }
}