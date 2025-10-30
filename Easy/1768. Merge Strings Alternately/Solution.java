class Solution {
    public String mergeAlternately(String word1, String word2) {
        StringBuilder mergeStr = new StringBuilder();
        int longWordLength = Math.max(word1.length(),word2.length());
        for(int i=0;i<longWordLength;i++){
            if(word1.length()>i){
                mergeStr.append(word1.charAt(i));
            }
            if(word2.length()>i){
                mergeStr.append(word2.charAt(i));
            }
        }
        return mergeStr.toString();
    }
}
