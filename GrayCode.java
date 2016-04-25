class Solution {
    ArrayList<Integer> list;
    public List<Integer> grayCode(int n) {

        list = new ArrayList<>();
        list.add(0);
        for(int i = 0 ; i < n ; i++){
            int step=1<<i;
            for(int j = list.size()-1;j>=0;j--){
                list.add(list.get(j)+step);
            }
        }
        return list;
    }

}
