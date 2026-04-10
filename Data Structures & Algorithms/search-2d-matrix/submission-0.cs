public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        // 2d matrices can be flattened down into 1d matrices pretty easily.
        int left = 0;
        int right = matrix.Length * matrix[0].Length - 1;
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            int midRow = mid / matrix[0].Length;
            int midCol = mid % matrix[0].Length;
            Console.WriteLine($"mid: {mid}");
            Console.WriteLine($"{midRow}, {midCol}");
            if(matrix[midRow][midCol] == target)
                return true;
            // on right
            if(matrix[midRow][midCol] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return false;
    }
}
