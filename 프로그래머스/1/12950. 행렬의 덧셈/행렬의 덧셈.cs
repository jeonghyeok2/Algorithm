public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int[,] answer = new int[arr1.GetLength(0),arr1.GetLength(1)];
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int d = 0; d < arr1.GetLength(1); d++)
                answer[i, d] = arr1[i, d] + arr2[i, d];
        }
        return answer;
    }
}