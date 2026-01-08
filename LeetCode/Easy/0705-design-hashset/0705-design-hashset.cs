public class MyHashSet {
    private SortedList<int, bool> map = new();

    public void Add(int key) {
        if (!map.ContainsKey(key))
            map[key] = true;
    }

    public void Remove(int key) {
        map.Remove(key);
    }

    public bool Contains(int key) {
        return map.ContainsKey(key);
    }
}
