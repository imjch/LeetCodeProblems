    public class Solution
    {
        private void GetConnectedNodes(string beginWord, ISet<string> wordList, Queue<string> queue)
        {
          
            var sb = new StringBuilder(beginWord);
            for (var i = 0; i < sb.Length; i++)
            {
                var c = sb[i];
                for (var j = 0; j < 26; j++)
                {
                    sb[i] = Convert.ToChar(Convert.ToInt16('a')+j);
                    var str = sb.ToString();
                    if (wordList.Contains(str))
                    {
                        queue.Enqueue(str);
                        wordList.Remove(str);
                    }
                }
                sb[i] = c;

            }
        }

        public int LadderLength(string beginWord, string endWord, ISet<string> wordList)
        {
            wordList.Add(endWord);
            wordList.Remove(beginWord);
            var count = 2;
            var queue=new Queue<string>();
            GetConnectedNodes(beginWord, wordList, queue);
            while (queue.Count != 0)
            {
                var connectedNodeCount = queue.Count;
              
                for (var i = 0; i < connectedNodeCount; i++)
                {
                    var node = queue.Peek();
                    GetConnectedNodes(node,wordList,queue);
                    if (queue.ElementAt(0) == endWord)
                    {
                        return count;
                    }
                    queue.Dequeue();
                }
                count++;
            }
            return 0;
        }
    }
