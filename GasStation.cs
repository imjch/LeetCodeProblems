public class Solution {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            if (gas.Length < cost.Length || gas.Length == 0 && cost.Length == 0)
            {
                return 0;
            }
            var start = gas.Length - 1;
            var end = 0;
            var sum = gas[start] - cost[start];
            while (start > end)
            {
                if (sum >= 0)
                {
                    sum += gas[end] - cost[end];
                    ++end;
                }
                else
                {
                    --start;
                    sum += gas[start] - cost[start];
                }
            }
            return sum>=0?start:-1;
        }
}