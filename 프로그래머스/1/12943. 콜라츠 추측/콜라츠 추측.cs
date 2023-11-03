public class Solution {
    public int solution(int num) {
        long temp = num;
        int count = 0;
        while (temp != 1)
        {
             ++count;
             temp = temp % 2 == 0 ? temp / 2 : (temp * 3) + 1;
             if (count >= 500)
                return -1;
        }   
            return count;
    }
}