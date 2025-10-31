import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.OptionalInt;

class Solution {
    public List<Boolean> kidsWithCandies(int[] candies, int extraCandies) {
        List<Boolean> hasMaxCandies = new ArrayList<>();
        OptionalInt maxCandies = Arrays.stream(candies).max();
        
        for (int candy : candies) {
            hasMaxCandies.add((candy + extraCandies) >= maxCandies.getAsInt());
        }
        return hasMaxCandies;
    }
}