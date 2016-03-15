
class Solution {
    public String TH(int num) {
        if (num == 1) {
            return "M";
        }
        if (num == 2) {
            return "MM";
        }
        if (num == 3) {
            return "MMM";

        }
        return "";
    }

    public String H(int num) {
        StringBuilder sb = new StringBuilder();
        while (num > 0) {
            if (num >= 9) {
                sb.append("CM");
                num -= 9;
            } else if (num >= 5) {
                sb.append("D");
                num -= 5;
            } else if (num >= 4) {
                sb.append("CD");
                num -= 4;
            } else {
                sb.append("C");
                num-=1;
            }
        }
        return sb.toString();
    }
    public String O(int num) {
        StringBuilder sb = new StringBuilder();
        while (num > 0) {
            if (num >= 9) {
                sb.append("IX");
                num -= 9;
            } else if (num >= 5) {
                sb.append("V");
                num -= 5;
            } else if (num >= 4) {
                sb.append("IV");
                num -= 4;
            } else {
                sb.append("I");
                num-=1;
            }
        }
        return sb.toString();
    }

    public String T(int num) {
        StringBuilder sb = new StringBuilder();
        while (num > 0) {
            if (num >= 9) {
                sb.append("XC");
                num -= 9;
            } else if (num >= 5) {
                sb.append("L");
                num -= 5;
            } else if (num >= 4) {
                sb.append("XL");
                num -= 4;
            } else {
                sb.append("X");
                num-=1;
            }
        }
        return sb.toString();
    }

    public String intToRoman(int num) {

        int num2 = num;
        StringBuilder sb = new StringBuilder();

        int count=1;
        while (num2 > 0) {
            int val = num2 % 10;
            if (count == 1) {
                sb.insert(0, O(val));
            }
            else if (count == 2) {
                sb.insert(0, T(val));
            }
            else if(count==3){
                sb.insert(0, H(val));
            }
            else{
                sb.insert(0, TH(val));
            }
            num2 /= 10;
            count++;
        }
        return sb.toString();
    }
}
