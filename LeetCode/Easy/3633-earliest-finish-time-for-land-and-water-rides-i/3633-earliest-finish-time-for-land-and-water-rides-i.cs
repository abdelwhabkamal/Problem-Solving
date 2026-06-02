public class Solution {
    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration) {
        int finish = int.MaxValue;
        int land = int.MaxValue;
        int water = int.MaxValue;
        for(int i = 0; i < landStartTime.Length; i++){
            land = Math.Min(land , landStartTime[i] + landDuration[i]);
        }
        for(int i = 0; i < waterStartTime.Length; i++){
            water = Math.Min(water , waterStartTime[i] + waterDuration[i]);
        }
        for(int i = 0; i < landStartTime.Length; i++){
            finish = Math.Min(finish ,Math.Max(water , landStartTime[i])+ landDuration[i]);
        }
        for(int i = 0; i < waterStartTime.Length; i++){
            finish = Math.Min(finish ,Math.Max(land , waterStartTime[i])+ waterDuration[i]);
        }
        return finish;
    }
}