
class Solution {
    public UndirectedGraphNode cloneGraph(UndirectedGraphNode node) {
        if (node == null) {
            return null;
        }

        Map<Integer, UndirectedGraphNode> refList = new HashMap<>();
        Set<Integer> visited = new HashSet<>();
        Queue<UndirectedGraphNode> queue = new LinkedList<>();
        queue.offer(node);
        while (queue.size() != 0) {
            UndirectedGraphNode head= queue.poll();
            UndirectedGraphNode newNode=null;
            if (refList.containsKey(head.label)) {
                newNode = refList.get(head.label);
            } else {
                newNode = new UndirectedGraphNode(head.label);
                refList.put(newNode.label, newNode);
            }

            visited.add(newNode.label);

            for(UndirectedGraphNode x : head.neighbors){
                UndirectedGraphNode u=null;
                if(refList.containsKey(x.label)){
                    u=refList.get(x.label);
                }
                else{
                    u=new UndirectedGraphNode(x.label);
                    refList.put(u.label, u);
                }
                newNode.neighbors.add(u);

            }
            head.neighbors.stream().forEach(x -> {
                if (!visited.contains(x.label)){
                    queue.offer(x);
                    visited.add(x.label);
                }
            });

        }
        return refList.get(node.label);
    }
}
