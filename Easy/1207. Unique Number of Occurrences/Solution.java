class Solution {
    public boolean uniqueOccurrences(int[] arr) {
        Map<Integer,Integer> counter = new HashMap<>();
        HashSet<Integer> checking = new HashSet<>();
        for(int num: arr){
            if(counter.containsKey(num)){
                counter.put(num,counter.get(num)+1);
            }
            else {
                counter.put(num,1);
            }
        }
        
        for(int num1: counter.values()){
            if(checking.contains(num1)){
                return false;
            }
            else {
                checking.add(num1);
            }
        }
        return true;
        
    }
}