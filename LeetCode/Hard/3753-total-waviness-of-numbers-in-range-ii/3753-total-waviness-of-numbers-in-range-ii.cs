using System;

public class Solution {
    private (long Count, long Waviness)[,,,,] memo;

    public long TotalWaviness(long num1, long num2) {
        return Solve(num2) - Solve(num1 - 1);
    }

    private long Solve(long num) {
        if (num <= 0) return 0;
        string limitStr = num.ToString();
        int n = limitStr.Length;
        
        memo = new (long Count, long Waviness)[n + 1, 12, 12, 2, 2];
        
        for (int i = 0; i <= n; i++) {
            for (int j = 0; j < 12; j++) {
                for (int k = 0; k < 12; k++) {
                    for (int l = 0; l < 2; l++) {
                        for (int m = 0; m < 2; m++) {
                            memo[i, j, k, l, m] = (-1, -1);
                        }
                    }
                }
            }
        }

        return Dp(0, -1, -1, false, false, limitStr).Waviness;
    }

    private (long Count, long Waviness) Dp(int index, int prevDigit, int prev2Digit, bool isLess, bool isStarted, string limitStr) {
        if (index == limitStr.Length) {
            return (isStarted ? 1 : 0, 0);
        }

        int p1Idx = prevDigit + 1;
        int p2Idx = prev2Digit + 1;
        int isLessIdx = isLess ? 1 : 0;
        int isStartedIdx = isStarted ? 1 : 0;

        if (memo[index, p1Idx, p2Idx, isLessIdx, isStartedIdx].Count != -1) {
            return memo[index, p1Idx, p2Idx, isLessIdx, isStartedIdx];
        }

        int limit = isLess ? 9 : (limitStr[index] - '0');
        long totalCount = 0;
        long totalWaviness = 0;

        for (int d = 0; d <= limit; d++) {
            bool nextIsStarted = isStarted || (d > 0);
            int nextPrevDigit = nextIsStarted ? d : -1;
            int nextPrev2Digit = nextIsStarted ? (isStarted ? prevDigit : -1) : -1;
            bool nextIsLess = isLess || (d < limit);

            int isPeakOrValley = 0;
            if (isStarted && prev2Digit != -1) {
                if (prevDigit > prev2Digit && prevDigit > d) {
                    isPeakOrValley = 1;
                } else if (prevDigit < prev2Digit && prevDigit < d) {
                    isPeakOrValley = 1;
                }
            }

            var (subCount, subWaviness) = Dp(index + 1, nextPrevDigit, nextPrev2Digit, nextIsLess, nextIsStarted, limitStr);
            
            totalCount += subCount;
            totalWaviness += subWaviness + isPeakOrValley * subCount;
        }

        return memo[index, p1Idx, p2Idx, isLessIdx, isStartedIdx] = (totalCount, totalWaviness);
    }
}