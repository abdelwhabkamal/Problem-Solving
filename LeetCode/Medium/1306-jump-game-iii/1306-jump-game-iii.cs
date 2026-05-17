public class Solution {
    HashSet<int> visited = new();
    public bool CanReach(int[] arr, int start) {
        bool DFS(int i){
            if(i < 0 || i >= arr.Length) return false;
            if(arr[i] == 0) return true;
            visited.Add(i);
            int left = i - arr[i];
            int right = i + arr[i];
            if(!visited.Contains(left) && DFS(left)) return true;
            if(!visited.Contains(right) && DFS(right)) return true;
            return false;
        }
        return DFS(start);
    }
}