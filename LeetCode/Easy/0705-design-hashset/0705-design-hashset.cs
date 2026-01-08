public class MyHashSet {
    Dictionary<int, int> set;
    public MyHashSet() {
        set = new();
    }
    
    public void Add(int key) {
        if(!set.ContainsKey(key)){
            set[key] = 0;
        }
    }
    
    public void Remove(int key) {
        set.Remove(key);
    }
    
    public bool Contains(int key) {
        return set.ContainsKey(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */