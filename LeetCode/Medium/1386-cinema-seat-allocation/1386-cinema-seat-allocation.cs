public class Solution {
    public int MaxNumberOfFamilies(int n, int[][] reservedSeats) {
        Dictionary<int, HashSet<int>> seats = new();
        foreach (var r in reservedSeats) {
            if (!seats.ContainsKey(r[0])) seats[r[0]] = new HashSet<int>();
            seats[r[0]].Add(r[1]);
        }

        int groups = n * 2;
        foreach (var kvp in seats) {
            bool left = !(kvp.Value.Contains(2) || kvp.Value.Contains(3) || kvp.Value.Contains(4) || kvp.Value.Contains(5));
            bool right = !(kvp.Value.Contains(6) || kvp.Value.Contains(7) || kvp.Value.Contains(8) || kvp.Value.Contains(9));
            bool middle = !(kvp.Value.Contains(4) || kvp.Value.Contains(5) || kvp.Value.Contains(6) || kvp.Value.Contains(7));

            if (left && right) continue;
            else if (left || right || middle) groups--; 
            else groups -= 2; 
        }
        return groups;
    }
}
