Implement a trie with insert, search, and startsWith methods.

     class TrieNode
    {
        // Initialize your data structure here.
        public TrieNode[] next = new TrieNode[26];
        public bool hasNext = false;
        public bool hasVal = false;
        public TrieNode()
        {

        }
    }

     class Trie
    {
        private TrieNode root;

        public Trie()
        {
            root = new TrieNode();
        }

        // Inserts a word into the trie.
        public void Insert(String word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return;
            }
            root= Insert(root,word, 0);
        }

        public TrieNode Insert(TrieNode node, string word, int depth)
        {
            if (node==null)
            {
                node = new TrieNode();
            }
            if (depth==word.Length)
            {
                node.hasVal = true;
                return node;
            }
            node.hasNext = true;
            node.next[word[depth] - 'a'] = Insert(node.next[word[depth] - 'a'], word, depth + 1);
            return node;
        }
        // Returns if the word is in the trie.
        public bool Search(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return false;
            }
            return Search(root,word, 0);
        }

         public bool Search(TrieNode node, string word, int depth)
         {
             if (word.Length == depth)
             {
                 return node.hasVal;
             }
             return node.next[word[depth] - 'a'] != null && Search(node.next[word[depth] - 'a'], word, depth + 1);
         }

         // Returns if there is any word in the trie
        // that starts with the given prefix.
        public bool StartsWith(string word)
         {
             if (string.IsNullOrEmpty(word))
             {
                 return false;
             }
            return StartsWith(root,word, 0);
        }

         public bool StartsWith(TrieNode node,string word, int depth)
         {
             if (depth==word.Length-1)
             {
                 return node.next[word[depth] - 'a'] != null;
             }
             return node.next[word[depth] - 'a'] != null && StartsWith(node.next[word[depth] - 'a'], word, depth + 1);
         }

    }