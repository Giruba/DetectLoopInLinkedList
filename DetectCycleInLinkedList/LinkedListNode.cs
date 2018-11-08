using System;
using System.Collections.Generic;
using System.Text;

namespace DetectCycleInLinkedList
{
    class LinkedListNode
    {
        int data;
        LinkedListNode next;

        public LinkedListNode(int data) {
            this.data = data;
        }

        public int GetLinkedListData() {
            return data;
        }

        public LinkedListNode GetLinkedListPointer() {
            return next;
        }

        public void SetLinkedListData(int data) {
            this.data = data;
        }

        public void SetLinkedListPointer(LinkedListNode next) {
            this.next = next;
        }
    }
}
