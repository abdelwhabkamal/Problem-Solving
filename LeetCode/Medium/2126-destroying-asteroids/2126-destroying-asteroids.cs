public class Solution {
    public bool AsteroidsDestroyed(int mass, int[] asteroids) {
        if(mass >= asteroids.Max()) return true;
        List<int> rem = new();
        long cap = mass;
        for(int i = 0; i < asteroids.Length; i++){
            if(asteroids[i] <= cap) cap += asteroids[i];
            else rem.Add(asteroids[i]);
        }
        rem.Sort();
        for(int i = 0; i < rem.Count; i++){
            if(rem[i] > cap) return false;
            else cap += rem[i];
        }
        return true;
    }
}