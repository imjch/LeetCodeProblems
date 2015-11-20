public class Solution {
	 // What a fucking style of this statement of code...
         public bool SearchMatrix(int[,] matrix, int target)
         {
             int rows = matrix.GetLength(0);
             int cols = matrix.GetLength(1);

             int length = rows;
             int begin = 0;
             while (length>0)
             {
                 int half = length >> 1;
                 int mid = begin+ half;
                 if (matrix[mid, 0] == target)
                 {
                     return true;
                 }
                 else if (matrix[mid, 0] < target)
                 {
                     length = length - half - 1;
                     begin = mid+1;
                 }
                 else
                 {
                     length = half;
                 }
             }
             if (begin>rows-1)
             {
                 if (matrix[begin-1, 0] == target)
                 {
                     return true;
                 }
             }
             else if (matrix[begin, 0] == target)
             {
                 return true;
             }
             else
             { 
             
             }

             if (begin==0)
             {
                 return false;
             }

             var rowIndex=begin-1;

             begin = 0;
             int end = cols - 1;
             while (begin<=end)
             {
                  int mid = (begin + end) / 2;
                  if (matrix[rowIndex,mid]==target)
	              {
                      return true;
                  }
                  else if (matrix[rowIndex, mid] > target)
                  {
                      end = mid - 1;
                  }
                  else
                  {
                      begin = mid + 1;
                  }
             }
             return false;
         }
}