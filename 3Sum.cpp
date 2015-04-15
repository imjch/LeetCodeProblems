vector<vector<int> > threeSum(vector<int> &num)
	{
		sort(num.begin(), num.end());
		vector<vector<int>> vectorList;
		int len = num.size();
		
                //this for statement can ensuare no duplicate triplets in vectorList
		for (int i = 0; i < len; i++)
		{
			if (num[i]>0)
			{
				break;
			}
			if (i>0&&num[i]==num[i-1])
			{
				continue;
			}
			for (int j = i + 1, k = len - 1; j < k;)
			{
				if (num[i] + num[j] + num[k] == 0)
				{
					vectorList.push_back({ num[i], num[j], num[k] });
					int val = num[j];
					j++;
					while (j < k && num[j] == val)
						j++;
				}
				else if (num[i] + num[j] + num[k] > 0)
				{
					int val = num[k];
					k--;
					while (j < k && num[k] == val)
						k--;
				}
				else
				{
					int val = num[j];
					j++;
					while (j < k && num[j] == val)
						j++;
				}
			}
		}
	
		return vectorList;
	}