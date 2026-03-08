using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);

        var result = new List<IList<int>> {
            set1.Except(set2).ToList(),
            set2.Except(set1).ToList()
        };

        return result;
    }
}