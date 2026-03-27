public class Solution {
    public bool AreSimilar(int[][] mat, int k) {
        if (k % mat[0].Length == 0)
        {
            return true;
        }

        foreach (var row in mat)
        {
            for (var i = 0; i < row.Length; i++)
            {
                if (row[i] != row[(i + k) % row.Length])
                {
                    return false;
                }
            }
        }

        return true;
    }
}