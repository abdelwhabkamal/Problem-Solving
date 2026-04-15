public class Solution {
    public int ClosestTarget(string[] words, string target, int startIndex) {
        int n = words.Length;
        int answer = int.MaxValue;

        for (int i = 0; i < n; i++) {
            if (words[i] == target) {
                // distance in circular array
                int dist = Math.Min(Math.Abs(i - startIndex), n - Math.Abs(i - startIndex));
                answer = Math.Min(answer, dist);
            }
        }

        return answer == int.MaxValue ? -1 : answer;
    }
}
