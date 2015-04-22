	int threeSumClosest(std::vector<int> &num, int target) {
		sort(num.begin(), num.end());

		int len = num.size();
	
		//auto minVal = INT_MAX;
		//auto previousVal = 0;
		if (num.size()<=3)
		{
			return accumulate(num.begin(),num.end(),0);
		}
		auto result = num[0] + num[1] + num[2];
		for (auto i = 0; i < len-2; i++)
		{
			for (auto j = i + 1, k = len-1; j<k;)
			{
				auto sum = num[i] + num[j] + num[k];
				if (sum==target)
				{
					return sum;
				}
				
				if (abs(sum-target)<abs(result-target))
				{
					result = sum;
				}
				sum < target ? j++ : k--;
			}
		}

		return result;
	}