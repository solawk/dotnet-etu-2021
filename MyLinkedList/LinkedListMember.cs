using System;
using System.Collections.Generic;
using System.Text;

namespace MyLinkedList
{
    class LinkedListMember
    {
        private int _data = 0;

        private LinkedListMember _prev = null;
        private LinkedListMember _next = null;

        public LinkedListMember(int data)
        {
            _data = data;
        }

        public LinkedListMember GetPrev()
        {
            return _prev;
        }

        public LinkedListMember GetNext()
        {
            return _next;
        }

        public void SetPrev(LinkedListMember prev)
        {
            _prev = prev;
        }

        public void SetNext(LinkedListMember next)
        {
            _next = next;
        }

        public void SetData(int data)
        {
            _data = data;
        }

        public int GetData()
        {
            return _data;
        }
    }
}
