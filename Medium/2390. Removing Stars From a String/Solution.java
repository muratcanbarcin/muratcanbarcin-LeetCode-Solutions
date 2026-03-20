class Solution {
    public String removeStars(String s) {
        Stack<Character> sChars = new Stack<>();
        
        for(int i =0;i<s.length();i++){
            if(s.charAt(i)=='*'){
                int index = sChars.size()-1;
                while (sChars !=null){
                    if(sChars.get(index)!='*'){
                        sChars.pop();
                        break;
                    }
                    sChars.pop();
                    index--;
                }
            }
            else{
                sChars.add(s.charAt(i));
            }
        }
      StringBuilder sb = new StringBuilder();
        for (Character ch : sChars) {
            sb.append(ch);
        }
        return  sb.toString();
    }
}