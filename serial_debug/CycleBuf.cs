using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffer
{
    public class CycleBuf<T>
    {
        private T[] _countainer;
        private int _position;
        private int _length;

        public int length { get { return _length; } }
        public int position { get { return _position; } }

        public CycleBuf(int len)
        {
            _position = 0;
            _length = len;
            _countainer = new T[len];
        }

        public T this[int index]
        {
            get
            {
                return _countainer[(_position + index) % _length];
            }
            set
            {
                _countainer[(_position + index) % _length] = value;
            }
        }

        public void Insert(T item)
        {
            _countainer[_position] = item;
            _position = (_position + 1) % _length;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new CycleBufEnumerator<T>(this);
        }
    }

    public class CycleBufEnumerator<T> : IEnumerator<T>
    {
        public CycleBufEnumerator(CycleBuf<T> buf)
        {

        }

        public T Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        object IEnumerator.Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
