using System;

public class Solution {
    public int solution(int price)
    {
        if (price >= 500000)
            price = (int)(price * 0.8f);
        else if (price >= 300000)
            price = (int)(price * 0.9f);
        else if (price >= 100000)
            price = (int)(price * 0.95f);
        return price;
    }
}