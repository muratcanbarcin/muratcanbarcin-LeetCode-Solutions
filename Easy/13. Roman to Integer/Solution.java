class Solution {
    public int romanToInt(String s) {
        char[] sArray = s.toCharArray();
        int num1=romanAlphabet(sArray[0]);
        int num2=0;
        int output =num1;
        for(int i=1;i<sArray.length;i++){
            num2 = romanAlphabet(sArray[i]);
            if(num1 * 5 == num2 || num1*10 ==num2){
                output+=num2-num1;
                output-=num1;
            }
            else {
                output +=num2;
            }
            num1 =num2;
        }
        return output;
    }

    public int romanAlphabet(char c){
        switch(c) {
            case 'M':
                return 1000;
            case 'D':
                return 500;
            case 'C':
                return 100;
            case 'L':
                return 50;
            case 'X':
                return 10;
            case 'V':
                return 5;
            case 'I':
                return 1;
            default:
                return 0;

        }
    }

}