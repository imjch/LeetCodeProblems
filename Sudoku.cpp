class Solution {
public:
	vector<char> collect(vector<char> v)
	{
		vector<char> vec;
		for (auto iter = v.begin(); iter != v.end(); ++iter)
		{
			if (*iter!='.')
			{
				vec.push_back(*iter);
			}
		}
		return vec;
	}
	bool isValidChain(vector<char> vv)
	{
		auto v = collect(vv);
		unordered_set<char> set;
		for (auto iter = v.begin(); iter != v.end(); ++iter)
		{
			if (set.count(*iter)>0)
			{
				return false;
			}
			set.insert(*iter);
		}
		return true;
	}

	bool isValidSudoku(vector<vector<char>>& board) {
		for (size_t i = 0; i < 9; i++)
		{
			if (!isValidChain(board[i]))
			{
				return false;
			}
		}
		vector<char> v;
		for (size_t i = 0; i < 9; i++)
		{
			v.clear();
			for (size_t j = 0; j < 9; j++)
			{
				v.push_back(board[j][i]);
			}
			if(!isValidChain(v))
			{
				return false;
			}
		}
		v.clear();
		for (size_t i = 0; i < 9; i+=3)
		{
	
			for (size_t j = 0; j < 9; j+=3)
			{
				if (board[i][j]!='.')
				{
					v.push_back(board[i][j]);
				}
				if (board[i][j + 1]!='.')
				{
					v.push_back(board[i][j + 1]);
				}
				if (board[i][j + 2] != '.')
				{
					v.push_back(board[i][j + 2]);
				}
				if (board[i + 1][j] != '.')
				{
					v.push_back(board[i + 1][j]);
				}
				if (board[i + 1][j + 1] != '.')
				{
					v.push_back(board[i + 1][j + 1]);
				}
				if (board[i + 1][j + 2] != '.')
				{
					v.push_back(board[i + 1][j + 2]);
				}
				if (board[i + 2][j] != '.')
				{
					v.push_back(board[i + 2][j]);
				}
				if (board[i + 2][j + 1] != '.')
				{
					v.push_back(board[i + 2][j + 1]);
				}
				if (board[i + 2][j + 2] != '.')
				{
					v.push_back(board[i + 2][j + 2]);
				}
				if (!isValidChain(v))
				{
					return false;
				}
				v.clear();
			}
		}
		return true;
	}
};