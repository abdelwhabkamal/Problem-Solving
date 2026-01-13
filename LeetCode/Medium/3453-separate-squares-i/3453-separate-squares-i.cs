public class Solution {
    public double SeparateSquares(int[][] squares) {
        // Calculate total area
        long totalArea = 0;
        foreach (var sq in squares) {
            long side = sq[2];
            totalArea += side * side;
        }
        
        double halfArea = totalArea / 2.0;
        
        // Collect all critical y-coordinates (bottom and top of each square)
        var events = new List<long>();
        foreach (var sq in squares) {
            long yi = sq[1];
            long li = sq[2];
            events.Add(yi);
            events.Add(yi + li);
        }
        
        // Sort and remove duplicates
        events = events.Distinct().OrderBy(x => x).ToList();
        
        // Sweep through critical y-values
        double areaBelowPrev = 0;
        
        for (int i = 0; i < events.Count - 1; i++) {
            long yLow = events[i];
            long yHigh = events[i + 1];
            
            // Calculate how much area is added per unit of y in this segment
            long widthSum = 0;
            foreach (var sq in squares) {
                long yi = sq[1];
                long li = sq[2];
                
                // Check if this square spans the segment [yLow, yHigh]
                if (yi <= yLow && yi + li >= yHigh) {
                    widthSum += li;
                }
            }
            
            // Area added in this segment = widthSum * (yHigh - yLow)
            double segmentArea = (double)widthSum * (yHigh - yLow);
            double areaBelowHigh = areaBelowPrev + segmentArea;
            
            // Check if halfArea falls within this segment
            if (areaBelowHigh >= halfArea) {
                double y = yLow + (halfArea - areaBelowPrev) / widthSum;
                return y;
            }
            
            areaBelowPrev = areaBelowHigh;
        }
        
        return events[events.Count - 1];
    }
}