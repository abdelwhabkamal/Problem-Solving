public class Solution {
    public long LargestSquareArea(int[][] bottomLeft, int[][] topRight) {
        int n = bottomLeft.Length;
        long bestSide = 0;

        for (int a = 0; a < n; a++) {
            int leftA = bottomLeft[a][0], bottomA = bottomLeft[a][1];
            int rightA = topRight[a][0], topA = topRight[a][1];

            if (rightA - leftA <= bestSide || topA - bottomA <= bestSide)
                continue;

            for (int b = a + 1; b < n; b++) {
                int leftB = bottomLeft[b][0], bottomB = bottomLeft[b][1];
                int rightB = topRight[b][0], topB = topRight[b][1];

                int overlapLeft = Math.Max(leftA, leftB);
                int overlapBottom = Math.Max(bottomA, bottomB);
                int overlapRight = Math.Min(rightA, rightB);
                int overlapTop = Math.Min(topA, topB);

                if (overlapLeft < overlapRight && overlapBottom < overlapTop) {
                    long width = overlapRight - overlapLeft;
                    long height = overlapTop - overlapBottom;
                    long side = Math.Min(width, height);
                    bestSide = Math.Max(bestSide, side);
                }
            }
        }
        return bestSide * bestSide;
    }
}