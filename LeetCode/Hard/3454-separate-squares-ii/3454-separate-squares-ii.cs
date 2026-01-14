public class Solution {
    public double SeparateSquares(int[][] squares) {
        int n = squares.Length;
        
        // Coordinate compression for X
        var xSet = new SortedSet<long>();
        foreach (var sq in squares) {
            xSet.Add(sq[0]);
            xSet.Add((long)sq[0] + sq[2]);
        }
        var xCoords = xSet.ToList();
        var xIndex = new Dictionary<long, int>();
        for (int i = 0; i < xCoords.Count; i++) {
            xIndex[xCoords[i]] = i;
        }
        
        // Create events: (y, type, x1, x2)
        // type: 1 = bottom edge (add), -1 = top edge (remove)
        var events = new List<(long y, int type, int x1Idx, int x2Idx)>();
        foreach (var sq in squares) {
            long x1 = sq[0];
            long y1 = sq[1];
            long side = sq[2];
            long x2 = x1 + side;
            long y2 = y1 + side;
            
            events.Add((y1, 1, xIndex[x1], xIndex[x2]));   // Bottom edge - add
            events.Add((y2, -1, xIndex[x1], xIndex[x2]));  // Top edge - remove
        }
        
        // Sort: by y, then additions before removals at same y
        events.Sort((a, b) => {
            if (a.y != b.y) return a.y.CompareTo(b.y);
            return b.type.CompareTo(a.type);
        });
        
        // Segment tree for X-axis
        int m = xCoords.Count;
        var count = new int[4 * m];  // Count of rectangles covering each segment
        var len = new long[4 * m];   // Covered length
        
        void Update(int node, int start, int end, int l, int r, int val) {
            if (r <= start || end <= l) return;
            if (l <= start && end <= r) {
                count[node] += val;
            } else {
                int mid = (start + end) / 2;
                Update(2 * node, start, mid, l, r, val);
                Update(2 * node + 1, mid, end, l, r, val);
            }
            
            if (count[node] > 0) {
                len[node] = xCoords[end] - xCoords[start];
            } else if (end - start == 1) {
                len[node] = 0;
            } else {
                len[node] = len[2 * node] + len[2 * node + 1];
            }
        }
        
        // First pass: calculate total area
        double totalArea = 0;
        long prevY = events[0].y;
        
        foreach (var (y, type, x1Idx, x2Idx) in events) {
            if (y > prevY) {
                totalArea += (double)len[1] * (y - prevY);
            }
            Update(1, 0, m - 1, x1Idx, x2Idx, type);
            prevY = y;
        }
        
        double halfArea = totalArea / 2.0;
        
        // Reset segment tree
        Array.Clear(count, 0, count.Length);
        Array.Clear(len, 0, len.Length);
        
        // Second pass: find the y where cumulative area = halfArea
        double cumArea = 0;
        prevY = events[0].y;
        
        foreach (var (y, type, x1Idx, x2Idx) in events) {
            if (y > prevY && len[1] > 0) {
                double stripArea = (double)len[1] * (y - prevY);
                
                if (cumArea + stripArea >= halfArea) {
                    // Answer is in this strip
                    double needed = halfArea - cumArea;
                    double targetY = prevY + needed / len[1];
                    return targetY;
                }
                
                cumArea += stripArea;
            }
            Update(1, 0, m - 1, x1Idx, x2Idx, type);
            prevY = y;
        }
        
        return prevY;
    }
}