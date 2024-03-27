namespace Problems.HalloweenSale;

public class Solution : IRunnable<Arguments, int>
{
    public int Run(Arguments arguments)
    {
        int p = arguments.p;
        int d = arguments.d;
        int m = arguments.m;
        int s = arguments.s;

        int count = 0;
        int money = s;
        int currentPrice = p;
        while (money >= currentPrice)
        {
            money -= currentPrice;
            count++;
            currentPrice = Math.Max(currentPrice - d, m);
        }
        return count;
        
    }
}