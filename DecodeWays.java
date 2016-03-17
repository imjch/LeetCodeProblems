 class Solution {
    private int [] map;
    public int numDecodings(String s) {
        if(s.isEmpty()){
            return 0;
        }
        map = new int[s.length()];
        char[] arr = s.toCharArray();

        _numDecodings(arr, arr.length - 1);
        return map[0];
    }

     public void _numDecodings(char[] arr, int end) {
         if (end < 0) {
             return;
         }

         if (arr[end] == '1' || end<arr.length-1&& arr[end] == '2' && arr[end + 1] <= '6') {
             if (end < arr.length - 2) {
                 map[end] = map[end + 1]   + map[end + 2];
             }
             else if(end < arr.length -1){
                 map[end] = map[end + 1] + 1;
             }
             else{
                 map[end]=1;
             }
         } else {
             if(arr[end]=='0'){
                 map[end]=0;
             }
             else if(end < arr.length -1){
                 map[end] = map[end + 1];
             }
             else{
                 map[end] = 1;
             }
         }
         _numDecodings(arr, end - 1);
     }
 }
