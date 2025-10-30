class Solution {
    public string MergeAlternately(string word1, string word2) {
        int longWordLength = Math.max(word1.Length, word2.Length);
        StringBuilder mergeStr = new StringBuilder();

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