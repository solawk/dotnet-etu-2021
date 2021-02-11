using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyLinkedList
{
    class LinkedListEnum : IEnumerator<int>
    {
        private readonly LinkedList _list;
        private int _position = -1;

        public LinkedListEnum(LinkedList list)
        {
            _list = list;
        }

        public void Reset()
        {
            _position = -1;
        }

        public bool MoveNext()
        {
            _position++;

            return (_position < _list.GetSize());
        }

        public void Dispose()
        {
            
        }

        public int Current
        {
            get
            {
                return _list[_position];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
    }
}
