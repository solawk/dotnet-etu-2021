using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace MyLinkedList
{
    class LinkedListEnum : IEnumerator<int>
    {
        private LinkedListMember _currentMember;
        private LinkedListMember _nextMember;

        public LinkedListEnum(LinkedListMember firstMember)
        {
            _currentMember = null;
            _nextMember = firstMember;
        }

        public void Reset()
        {
            while (_currentMember.GetPrev() != null)
            {
                _currentMember = _currentMember.GetPrev();
            }

            _nextMember = _currentMember;
            _currentMember = null;
        }

        public bool MoveNext()
        {
            _currentMember = _nextMember;
            if (_currentMember != null) _nextMember = _nextMember.GetNext();

            return _currentMember != null;
        }

        public void Dispose()
        {
            
        }

        public int Current
        {
            get
            {
                return _currentMember.GetData();
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
