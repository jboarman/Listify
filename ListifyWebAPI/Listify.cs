using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListifyWebAPI
{
    class Listify : IList<int>, IEnumerable<int>
    {
        private IList<int> _iList = new List<int>();

        public int this[int index]
        {
            get
            {
                return _iList[index];
            }

            set
            {
                _iList[index] = value;
            }
        }

        int IList<int>.this[int index]
        {
            get
            {
                return _iList[index];
            }
            set
            {
                _iList[index] = value;
            }
        }

        internal void AddRange(IEnumerable<int> enumerable)
        {
            foreach (int elem in enumerable)
            {
                _iList.Add(elem);
            }
        }

        int ICollection<int>.Count => throw new NotImplementedException();

        bool ICollection<int>.IsReadOnly => throw new NotImplementedException();

        void ICollection<int>.Add(int item)
        {
            _iList.Add(item);
        }

        void ICollection<int>.Clear()
        {
            throw new NotImplementedException();
        }

        bool ICollection<int>.Contains(int item)
        {
            throw new NotImplementedException();
        }

        void ICollection<int>.CopyTo(int[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return _iList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        int IList<int>.IndexOf(int item)
        {
            throw new NotImplementedException();
        }

        void IList<int>.Insert(int index, int item)
        {
            throw new NotImplementedException();
        }


        bool ICollection<int>.Remove(int item)
        {
            throw new NotImplementedException();
        }

        void IList<int>.RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}
