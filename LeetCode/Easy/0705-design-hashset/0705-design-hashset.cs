public class MyHashSet {
    HashSet<int> set = new();
    public MyHashSet() {
        set=new HashSet<int>();
    }
    
    public void Add(int key) {
        set.Add(key);
    }
    
    public void Remove(int key) {
        set.Remove(key);
    }
    
    public bool Contains(int key) {
        if(set.Contains(key))return true;
        return false;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */