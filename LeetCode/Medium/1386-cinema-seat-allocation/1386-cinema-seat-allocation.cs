public class Solution {
    public int MaxNumberOfFamilies(int n, int[][] reservedSeats) {
        Dictionary<int , HashSet<int>> seats = new();
        for(int i = 0; i < reservedSeats.Length; i++){
            if(!seats.ContainsKey(reservedSeats[i][0])) seats[reservedSeats[i][0]] = new HashSet<int>();
            seats[reservedSeats[i][0]].Add(reservedSeats[i][1]);
        }
        int groups = n*2;
        foreach(var kvp in seats){
            if(kvp.Value.Contains(4) || kvp.Value.Contains(5)) {
                groups--;
                if(kvp.Value.Contains(6) || kvp.Value.Contains(7) || kvp.Value.Contains(8) || kvp.Value.Contains(9)) groups--;
            }
            else if(kvp.Value.Contains(6) || kvp.Value.Contains(7)){
                groups--;
                if(kvp.Value.Contains(2) || kvp.Value.Contains(3) || kvp.Value.Contains(4) || kvp.Value.Contains(5)) groups--;
            }
            else if(kvp.Value.Contains(2) || kvp.Value.Contains(3) || kvp.Value.Contains(8) || kvp.Value.Contains(9)) groups--;
        }
        return groups;
    }
}