public class Solution {
    private class Node {
        public long Value;
        public int Position;  
        public Node Prev;
        public Node Next;
        public bool IsDeleted;
        
        public Node(long value, int position) {
            Value = value;
            Position = position;
            IsDeleted = false;
        }
    }
    
    private class Pair : IComparable<Pair> {
        public Node Left;
        public Node Right;
        public long Sum;
        public int LeftPosition;
        
        public Pair(Node left, Node right) {
            Left = left;
            Right = right;
            Sum = left.Value + right.Value;
            LeftPosition = left.Position;
        }
        
        public bool IsValid() {
            return !Left.IsDeleted && !Right.IsDeleted && Left.Next == Right;
        }
        
        public int CompareTo(Pair other) {
            // First compare by sum
            int sumCompare = Sum.CompareTo(other.Sum);
            if (sumCompare != 0) return sumCompare;
            
            // If sums are equal, prefer leftmost (smaller position)
            return LeftPosition.CompareTo(other.LeftPosition);
        }
    }
    
    public int MinimumPairRemoval(int[] nums) {
        if (nums.Length <= 1) return 0;
        
        // Build doubly linked list with position tracking
        Node head = new Node(nums[0], 0);
        Node current = head;
        
        for (int i = 1; i < nums.Length; i++) {
            Node newNode = new Node(nums[i], i);
            current.Next = newNode;
            newNode.Prev = current;
            current = newNode;
        }
        
        // Use SortedSet for proper ordering with tie-breaking
        SortedSet<Pair> sortedPairs = new SortedSet<Pair>();
        current = head;
        
        while (current.Next != null) {
            Pair pair = new Pair(current, current.Next);
            sortedPairs.Add(pair);
            current = current.Next;
        }
        
        int operations = 0;
        
        while (sortedPairs.Count > 0) {
            // Get minimum pair (with leftmost tie-breaking)
            Pair minPair = sortedPairs.Min;
            sortedPairs.Remove(minPair);
            
            // Skip if invalid
            if (!minPair.IsValid()) {
                continue;
            }
            
            // Check if already non-decreasing
            if (IsNonDecreasing(head)) {
                break;
            }
            
            // Merge the pair
            Node left = minPair.Left;
            Node right = minPair.Right;
            
            // Remove old pairs involving left or right
            if (left.Prev != null && !left.Prev.IsDeleted) {
                sortedPairs.Remove(new Pair(left.Prev, left));
            }
            if (right.Next != null && !right.Next.IsDeleted) {
                sortedPairs.Remove(new Pair(right, right.Next));
            }
            
            // Mark right as deleted and update left's value
            right.IsDeleted = true;
            left.Value = minPair.Sum;
            left.Next = right.Next;
            
            if (right.Next != null) {
                right.Next.Prev = left;
                // Add new pair (left, right.Next)
                sortedPairs.Add(new Pair(left, right.Next));
            }
            
            if (left.Prev != null && !left.Prev.IsDeleted) {
                // Add new pair (left.Prev, left)
                sortedPairs.Add(new Pair(left.Prev, left));
            }
            
            operations++;
        }
        
        return operations;
    }
    
    private bool IsNonDecreasing(Node head) {
        Node current = head;
        long prevValue = long.MinValue;
        
        while (current != null) {
            if (!current.IsDeleted) {
                if (current.Value < prevValue) {
                    return false;
                }
                prevValue = current.Value;
            }
            current = current.Next;
        }
        return true;
    }
}