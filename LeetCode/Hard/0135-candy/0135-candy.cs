public class Solution {
    public int Candy(int[] ratings) {
        int n = ratings.Length;
        int[] candies = new int[n];
        candies[0] = 1;

        for(int i = 1; i < n; i++){
            candies[i] = 1;
            if(ratings[i] > ratings[i-1]){
                candies[i] = candies[i-1] + 1;
            }
        }
        int sum = candies[n-1];
        for(int i = n-1; i > 0; i--){
            if(ratings[i-1] > ratings[i]){
                candies[i-1] = Math.Max(candies[i] + 1 , candies[i-1]);
            }
            sum += candies[i];
        }

        return sum;
    }
}