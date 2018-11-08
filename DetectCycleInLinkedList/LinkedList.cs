using System;
using System.Collections.Generic;
using System.Text;

namespace DetectCycleInLinkedList
{
    class LinkedList
    {
        LinkedListNode headNode;

        public void Insert(int data) {
            headNode = InsertUtil(headNode, data);
        }

        public void SetHeadNode(LinkedListNode node) {
            headNode = node;
        }

        public LinkedListNode GetHeadNode() {
            return headNode;
        }
        private LinkedListNode InsertUtil(LinkedListNode node, int data) {

            if (node == null) {
                node = new LinkedListNode(data);
                return node;
            }

            while (node != null && node.GetLinkedListPointer() != null) {
                node = node.GetLinkedListPointer();
            }

            node.SetLinkedListPointer(new LinkedListNode(data));

            return node;
        }

        public void DetectLoopInLinkedList(LinkedListNode linkedListNode) {

            if (linkedListNode == null) {
                Console.WriteLine("The Linkedlist is null!");
                return;
            }

            LinkedListNode fast = linkedListNode;
            LinkedListNode slow = linkedListNode;

            while (fast!= null && slow != null && fast.GetLinkedListPointer() != null)
            {
                fast = fast.GetLinkedListPointer().GetLinkedListPointer();
                slow = slow.GetLinkedListPointer();

                if(fast == slow)
                {
                    Console.WriteLine("Loop detected in LinkedList at "+fast.GetLinkedListData());
                }
            }
            Console.WriteLine("There is no loop detected!");
        }
    }
}
