public class Solution {
    public int[] FindThePrefixCommonArray(int[] A, int[] B) {
        int[] res = new int[A.Length];

        int[] foundA = new int[A.Length + 1];
        int[] foundB = new int[A.Length + 1];
        int prevCount = 0;

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == B[i])
            {
                prevCount++;
            }
            else
            {
                foundA[A[i]] = 1;
                foundB[B[i]] = 1;

                if (foundA[B[i]] == 1)
                    prevCount++;
                if (foundB[A[i]] == 1)
                    prevCount++;
            }
            res[i] = prevCount;
        }

        return res;
    }
}