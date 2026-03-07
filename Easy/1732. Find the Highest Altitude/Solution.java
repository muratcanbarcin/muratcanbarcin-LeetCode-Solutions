class Solution {
    public int largestAltitude(int[] gain) {
        int max=0,currentAltitude=0;

        for(int altitude: gain){
            currentAltitude += altitude;
            max = Math.max(max,currentAltitude);
        }
        return max;
    }
}