public class Solution {
    public ListNode ModifiedList(int[] nums, ListNode head) {
        
        bool[] toDelete = new bool[100001];
        
        foreach (int num in nums) {
            toDelete[num] = true;
        }
        
        ListNode dummy = new ListNode(0, head);
        ListNode prev = dummy;
        ListNode current = head;
        
        while (current != null) {
            if (toDelete[current.val]) {
                prev.next = current.next;
            } else {
                prev = current;
            }
            current = current.next;
        }
        
        return dummy.next;
    }
}