 class Solution {
    public int romanToInt(String s) {
        StringBuilder sb=new StringBuilder();
        int val = 0;
        char[] arr =s.toCharArray();
        for(int i = arr.length-1 ; i >= 0; i--){
            switch (arr[i]){
                case 'I':

                    int temp=1;
                    while(i>0&&arr[i-1]=='I') {
                        temp++;
                        i--;
                    }
                    if(i>0&&arr[i-1]=='V'){
                        val+=5+temp;
                        i--;
                    }
                    else{
                        val+=temp;
                    }
                    break;
                case 'V':
                    if(i>0&&arr[i-1]=='I'){
                        i--;
                        val+=4;
                    }
                    else{
                        val+=5;
                    }
                    break;
                case 'X':
                    if(i>0&&arr[i-1]=='I'){
                        val+=9;
                        i--;
                    }
                    else{
                        val+=10;
                    }
                    break;
                case 'L':
                    if(i>0&&arr[i-1]=='X'){
                        val+=40;
                        i--;
                    }
                    else{
                        val+=50;
                    }
                    break;
                case 'C':
                    if(i>0&&arr[i-1]=='X'){
                        val+=90;
                        i--;
                    }
                    else{
                        val+=100;
                    }
                    break;
                case 'D':
                    if(i>0&&arr[i-1]=='C'){
                        val+=400;
                        i--;
                    }
                    else{
                        val+=500;
                    }
                    break;
                case 'M':
                    if(i>0&&arr[i-1]=='C'){
                        val+=900;
                        i--;
                    }
                    else{
                        val+=1000;
                    }
                    break;

            }
        }
        return val;
    }
}
