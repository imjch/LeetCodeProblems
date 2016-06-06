    class TrieNode
    {
        public TrieNode[] next = new TrieNode[26];
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
            node.next[word[depth] - 'a'] = Insert(node.next[word[depth] - 'a'], word, depth + 1);
            return node;
        }
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
             if (word[depth] == '.')
             {
                 var items = node.next.Where(x => x != null);

                 if (!items.Any())
                 {
                     return false;
                 }
                 if (items.Any(item => Search(item, word, depth + 1)))
                 {
                     return true;
                 }
                 return false;
             }
             else
             {
                 return node.next[word[depth] - 'a'] != null && Search(node.next[word[depth] - 'a'], word, depth + 1);
             }
         }
    }
    public class WordDictionary
    {
        private Trie t = new Trie();
        // Adds a word into the data structure.
        public void AddWord(String word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return;
            }
            t.Insert(word);
        }

        // Returns if the word is in the data structure. A word could
        // contain the dot character '.' to represent any one letter.
        public bool Search(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return false;
            }
            return t.Search(word);
        }
    }