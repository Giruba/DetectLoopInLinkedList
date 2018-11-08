#Author: Giruba Beulah SE
# DetectLoopInLinkedList
C# program to detect loop in a Linked List

Uses the Tortoise-Hare algorithm to detect loop in a Linked list

Logic/Algorithm:
1. Initialize two pointer, Fast and Slow both pointing to the Head node
2. While Fast != null && Slow != null && Fast.next != null, do the following
  2.a Set Fast = Fast.next.next
      Set Slow = Slow.next
      if(Fast == Slow), print that the loop is detected and return
3. Print there is no loop
