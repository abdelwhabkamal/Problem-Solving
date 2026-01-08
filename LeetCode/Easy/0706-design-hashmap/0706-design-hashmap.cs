public class MyHashMap {
    Dictionary<int,int> map = new();

    public MyHashMap() {
        map= new Dictionary<int,int>();
    }
    
    public void Put(int key, int value) {
        map[key]=value;
    }
    
    public int Get(int key){
        if(!map.ContainsKey(key))return -1;
        return map[key];
    }    
    public void Remove(int key) {
        map[key]=-1;
    }
}
