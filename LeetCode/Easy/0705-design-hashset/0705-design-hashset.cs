public class MyHashSet {
    int[] arr; 
    public MyHashSet() {
        arr =  new int[1000001]; 
    }
    
    public void Add(int key) {
        arr[key] = 1; 
    }
    
    public void Remove(int key) {
        arr[key] = 0; 
        
    }
    
    public bool Contains(int key)=> arr[key] == 1 ? true: false;
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */