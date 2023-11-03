public class Solution {
    public bool solution(int x) {
        char[] chArr = x.ToString().ToCharArray();
        int sum = 0;
        foreach (char ch in chArr) 
            sum += (int)char.GetNumericValue(ch);
        if (x % sum == 0)
            return true;
        else
            return false;
    }
}