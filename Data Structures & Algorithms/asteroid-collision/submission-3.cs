public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> store = new Stack<int>();
        for(int i=0; i< asteroids.Length;i++ ){
            int current = asteroids[i];
            while(store.Count > 0 && current < 0 && store.Peek() > 0){
              int diff = store.Peek() - Math.Abs(current);
             
              if(diff < 0){
                store.Pop();
              }else if(diff > 0){
                current =0;
              }else{
                store.Pop();
                current = 0;
              } 
            }
            
            if(current != 0){
                store.Push(current);
            }      
        }
        
         return store.Reverse().ToArray();

    }
}