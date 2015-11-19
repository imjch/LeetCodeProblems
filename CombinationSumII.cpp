class Solution {
public:
	vector<vector<int>> combinationSum2(vector<int>& candidates, int target) {
		sort(candidates.begin(), candidates.end());
		set<vector<int>> vectorSet;
		conbinationSum(candidates, vector<int>(), 0, 0, target, vectorSet);
		return vector<vector<int>>(vectorSet.begin(), vectorSet.end());
	}
private:
	void conbinationSum(vector<int>& candidates, vector<int> numberList, int pos, int accSum, int target, set<vector<int>>& vSets)
	{
		if (accSum==target)
		{
			vSets.insert(vector<int>(numberList.begin(),numberList.end()));
		}
		if (pos==candidates.size()||accSum>target)
		{
			return;
		}
		for (size_t i = pos; i < candidates.size(); i++)
		{
			numberList.push_back(candidates[i]);
			conbinationSum(candidates, numberList,i+1, accSum + candidates[i], target, vSets);
			numberList.pop_back();
		}
	}
};