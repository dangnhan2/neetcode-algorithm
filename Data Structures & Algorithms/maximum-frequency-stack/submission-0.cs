public class FreqStack {
    public List<int> store = new List<int>();
    public Dictionary<int,int> freq = new Dictionary<int,int>();
    public FreqStack() {
        
    }
    
    public void Push(int val) {
        if(!freq.ContainsKey(val)){
            freq[val] = 0;
        }

        freq[val]++;
        store.Add(val);
    }
    
    public int Pop() {
    if (store.Count == 0) return -1;

    int mostFreq = 0;
    int indexToRemove = -1;

    // Find the index of the most frequent element (latest one if tie)
    for (int i = store.Count - 1; i >= 0; i--) {
        int currentFreq = freq[store[i]];
        if (currentFreq > mostFreq) {
            mostFreq = currentFreq;
            indexToRemove = i;
        }
    }

    int element = store[indexToRemove];
    freq[element]--;
    store.RemoveAt(indexToRemove);

    return element;

    }
}

/**
 * Your FreqStack object will be instantiated and called as such:
 * FreqStack obj = new FreqStack();
 * obj.Push(val);
 * int param_2 = obj.Pop();
 */