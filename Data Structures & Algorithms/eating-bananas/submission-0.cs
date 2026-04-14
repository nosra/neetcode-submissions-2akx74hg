public class Solution {
    private static bool SimKokos(int[] piles, int speed, int hourLimit)
    {
        double hoursTaken = 0;
        for(int i = 0; i < piles.Length; i++)
        {
            int pile = piles[i];
            hoursTaken += Math.Ceiling((double)pile / speed);
        }
        return hoursTaken <= hourLimit;
    }
    public int MinEatingSpeed(int[] piles, int h) {
        // binary search, and run a simulation through each possible speed
        int left = 1;
        int right = piles.Max();
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            bool finishedInTime = SimKokos(piles, mid, h);
            if(finishedInTime)
                right = mid - 1;
            else
                left = mid + 1;
        }
        return left;
    }
}
