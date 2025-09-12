public class MyHashSet {
    private bool[] set;

    public MyHashSet() {
        set = new bool[1000001]; // range of keys
    }
    
    public void Add(int key) {
        set[key] = true;
    }
    
    public void Remove(int key) {
        set[key] = false;
    }
    
    public bool Contains(int key) {
        return set[key];
    }
}