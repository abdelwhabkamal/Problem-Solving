public class Solution {
    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration) {
        int early_land = int.MaxValue, early_water = int.MaxValue;
        for(int i=0; i<landStartTime.Length; i++)
            early_land = Math.Min(early_land, landStartTime[i] + landDuration[i]);
        for(int j=0; j<waterStartTime.Length; j++)
            early_water = Math.Min(early_water, waterStartTime[j] + waterDuration[j]);
        int min_time = int.MaxValue;
        for(int i=0; i<landStartTime.Length; i++)
            if(landStartTime[i]>=early_water)
                min_time = Math.Min(min_time, landStartTime[i] + landDuration[i]);
            else  min_time = Math.Min(min_time, early_water + landDuration[i]);
        for(int j=0; j<waterStartTime.Length; j++)
            if(waterStartTime[j]>=early_land)
                min_time = Math.Min(min_time, waterStartTime[j] + waterDuration[j]);
            else min_time = Math.Min(min_time, early_land + waterDuration[j]);
        return min_time;
    }
}