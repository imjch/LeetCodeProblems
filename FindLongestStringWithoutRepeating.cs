 //��̬�滮˼�룬ÿһ�ּ�¼��һ�ε��ַ���������¼currentLen
        static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            var visited = new int[256];
            for (var i = 0; i < 256; i++)
            {
                visited[i] = -1;//��ʼ������ֵΪ-1,��ʾδ����
            }
 

            var maxLen = 1;//��ʼʱ��󳤶�Ϊ1
            var currentLen = 1;//��ʼ����Ϊ1
           
            visited[s[0]] = 0;//��¼��һ��Ԫ�ص�����

            for (var i = 1; i < s.Length; i++)
            {
                int previousIndex = visited[s[i]];
                if (previousIndex == -1 || i - currentLen > previousIndex)//���δ���ʻ��ڵ�ǰ��Ӵ���
                {
                    currentLen++;
                }
                else
                {
                    maxLen = currentLen > maxLen ? currentLen : maxLen; 
                    currentLen = i - previousIndex;//���µ�ǰ����
                }
                visited[s[i]] = i;//�������һ�η��ʵ��ַ�������
            }
            maxLen = currentLen > maxLen ? currentLen : maxLen; 
            return maxLen;
        }