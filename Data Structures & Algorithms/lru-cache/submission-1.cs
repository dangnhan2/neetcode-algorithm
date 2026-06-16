public class LRUCache {
    public List<KeyValuePair<int, int>> store;
    public int capacity;
    public LRUCache(int capacity) {
        store = new List<KeyValuePair<int, int>>();
        this.capacity = capacity;
    }
    
    public int Get(int key) {
        for(int i =0; i< store.Count; i++){
            if(store[i].Key == key){
                var tmp = store[i];
                store.RemoveAt(i);
                store.Add(tmp);
                return tmp.Value;
            }
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        for(int i =0; i< store.Count; i++){
            if(store[i].Key == key){
                store.RemoveAt(i);
                store.Add(new KeyValuePair<int, int>(key, value));
                return;
            }
        }

        if(store.Count == capacity){
            store.RemoveAt(0);
        }

        store.Add(new KeyValuePair<int, int>(key, value));
    }
}
