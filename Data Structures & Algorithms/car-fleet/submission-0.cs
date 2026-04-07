class Solution{
    public int CarFleet(int target, int[] position, int[] speed) {
        // this is the worst problem on the entire website
        // sorting the array by position
        var cars = position.Zip(speed, (p, s) => (Pos: p, Speed: s))
                        .OrderByDescending(c => c.Pos)
                        .ToArray();

        int fleets = 0;
        double maxTimeSeenSoFar = 0;
        
        foreach(var car in cars) {
            double time = (double)(target - car.Pos) / car.Speed;
            if(time > maxTimeSeenSoFar) {
                fleets++;
                maxTimeSeenSoFar = time;
            }
        }
        return fleets;
    }
}