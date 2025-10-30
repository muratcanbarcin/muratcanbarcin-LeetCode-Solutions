class Solution {
    public int smallestNumber(int n) {
        int x=0,count =0;
        
        while (x<n){
            x+= Math.pow(2,count);
            count++;
        }
        
        return x;
    
    }
}