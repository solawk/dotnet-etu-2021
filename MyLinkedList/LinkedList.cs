using System;
using System.Collections.Generic;
using System.Text;

namespace MyLinkedList
{
    class LinkedList : IEnumerable<int>
    {
        private int _size;

        private LinkedListMember _first;

        private void InitFirst(LinkedListMember newFirst)
        {
            _first = newFirst;
            _first.SetPrev(null);
            _first.SetNext(null);
        }

        private int Clamp(int index)
        {
            if (index < 0) index = 0;
            if (index > _size) index = _size;

            return index;
        }

        public void Print()
        {
            Console.Write("{ ");

            for (int i = 0; i < _size; i++)
            {
                Console.Write(GetMemberData(i) + " ");
            }

            Console.WriteLine("}");
        }

        public void AddAs(int index, int data)
        {
            LinkedListMember newMember = new LinkedListMember(data);

            index = Clamp(index);

            if (_size == 0)
            {
                InitFirst(newMember);
            }
            else if (index == 0)
            {
                newMember.SetNext(_first);
                _first.SetPrev(newMember);
                _first = newMember;
            }
            else
            {
                LinkedListMember addAfterMember = GetMember(index - 1);

                LinkedListMember next = addAfterMember.GetNext();

                next?.SetPrev(newMember);
                addAfterMember.SetNext(newMember);

                newMember.SetPrev(addAfterMember);
                newMember.SetNext(next);
            }

            _size++;
        }

        public void AddFirst(int data)
        {
            AddAs(0, data);
        }

        public void AddLast(int data)
        {
            AddAs(_size, data);
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= _size) return;

            LinkedListMember targetMember = GetMember(index);

            LinkedListMember prev = targetMember.GetPrev();
            LinkedListMember next = targetMember.GetNext();

            prev?.SetNext(next);
            next?.SetPrev(prev);

            if (index == 0) _first = next;

            _size--;
        }

        public void Clear()
        {
            _size = 0;
            _first = null;
        }

        public void Reverse()
        {
            if (_size < 2) return;

            LinkedListMember currentMember = _first;
            LinkedListMember newFirst = null;

            while (currentMember != null)
            {
                LinkedListMember next = currentMember.GetNext();
                currentMember.SetNext(currentMember.GetPrev());
                currentMember.SetPrev(next);

                newFirst = currentMember;
                currentMember = next;
            }

            _first = newFirst;
        }

        private LinkedListMember GetMember(int index)
        {
            LinkedListMember targetMember = _first;

            for (int i = 0; i < index; i++)
            {
                targetMember = targetMember.GetNext();
            }

            return targetMember;
        }

        private void SetMemberData(int index, int data)
        {
            GetMember(index).SetData(data);
        }

        private int GetMemberData(int index)
        {
            return GetMember(index).GetData();
        }

        public int GetSize()
        {
            return _size;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new LinkedListEnum(this);
        }

        public int this[int index]
        {
            get
            {
                return GetMemberData(index);
            }

            set
            {
                SetMemberData(index, value);
            }
        }
    }
}
