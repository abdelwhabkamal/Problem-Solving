public class Solution {
    public bool CanReach(int[] arr, int start) {
        bool[] visited = new bool[arr.Length];
        bool DFS(int i){
            if(i < 0 || i >= arr.Length || visited[i]) return false;
            if(arr[i] == 0) return true;
            visited[i] = true;
            return DFS(i + arr[i]) || DFS( i - arr[i]);
        }
        return DFS(start);
    }
}