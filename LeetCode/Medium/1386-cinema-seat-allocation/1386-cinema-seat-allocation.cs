public class Solution {
    public int MaxNumberOfFamilies(int n, int[][] reservedSeats) {
        Dictionary<int, bool[]> rows = new();
        foreach (var seat in reservedSeats) {
            if (!rows.ContainsKey(seat[0])) rows[seat[0]] = new bool[11]; 
            rows[seat[0]][seat[1]] = true;
        }

        int groups = n * 2;
        foreach (var kvp in rows) {
            bool[] reserved = kvp.Value;

            bool left = !(reserved[2] || reserved[3] || reserved[4] || reserved[5]);
            bool right = !(reserved[6] || reserved[7] || reserved[8] || reserved[9]);
            bool middle = !(reserved[4] || reserved[5] || reserved[6] || reserved[7]);

            if (left && right) continue;       
            else if (left || right || middle) groups--; 
            else groups -= 2;                 
        }
        return groups;
    }
}
