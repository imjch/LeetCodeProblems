class Solution {
    List<List<String>> list= new ArrayList<>();
    List<String> l=new ArrayList<>();
    public List<List<String>> partition(String s) {
        _partition(0,s);
        return list;
    }
    private boolean isPalindrome(StringBuilder l){
        for(int i = 0,j=l.length()-1; i < j;i++,j--){
            if(l.charAt(i)!=l.charAt(j)){
                return false;
            }
        }
        return true;
    }
    private void _partition(int begin,String s) {
        if(begin==s.length()){
            list.add(new ArrayList<>(l));
            return;
        }
        StringBuilder sb=new StringBuilder();

        for(int i = begin;i<s.length();i++){
            if(sb.length()>=1&&sb.charAt(0)!=s.charAt(i)){
                sb.append(s.charAt(i));
                continue;
            }
            sb.append(s.charAt(i));
            if(isPalindrome(sb)){
                l.add(sb.toString());
            }
            else{
                continue;
            }
            _partition(i+1,s);
            if(l.size()>0)
                l.remove(l.size()-1);
        }
    }
}
