using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class HashTable<TKey, TValue>
    {
        public HashTable()
        {
            Init();
        }
        class Pair
        {
            public TKey Key;
            public TValue Value;
            public Pair Next;
        }

        Pair[] _table;
        int _capacity;
        int _count;
        const float DEFAULT_LOAD_FACTOR = (75f / 100);

        public int Count { get => _count; }

        public void Add(TKey key, TValue value)
        {
            if (++_count > _capacity * DEFAULT_LOAD_FACTOR)
            {
                Resize();
            }

            int index = GetIndex(key);

            if (_table[index] == null)
            {
                _table[index] = new Pair { Key = key, Value = value };
            }
            else
            {
                var current = _table[index];

                while (current.Next != null)
                    current = current.Next;

                current.Next = new Pair { Key = key, Value = value };
            }
        }

        public bool Remove(TKey key)
        {
            int index = GetIndex(key);

            var current = _table[index];

            if (current == null)
            {
                return false;
            }

            if (current.Key.Equals(key))
            {
                _table[index] = current.Next;
                current.Next = null;
                return true;
            }

            current = current.Next;

            while (current != null)
            {
                if (current.Next == null)
                    break;

                if (current.Next.Key.Equals(key))
                {
                    var buf = current.Next;
                    current.Next = buf.Next;
                    buf.Next = null;
                    return true;
                }

            }

            return false;
        }
        
        public void Print()
        {
            System.Console.WriteLine("------------");
            for (var i = 0; i < _capacity; i++)
            {
                System.Console.Write(i + ": ");
                if (_table[i] != null)
                {
                    System.Console.Write(_table[i].Key.ToString() + " ");
                    var cur = _table[i];
                    while (cur.Next != null) 
                    {
                        System.Console.Write(cur.Key.ToString() + " ");
                        cur = cur.Next;
                    }
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("------------");
            System.Console.WriteLine("");
        }
        private int GetIndex(TKey key)
        {
            return (key.GetHashCode()) % _capacity;
        }
        private void Resize()
        {

            int oldCapacity = _capacity;

            if (_capacity << 1 == 0)
                return;

            _capacity <<= 1;

            Pair[] newTable = new Pair[_capacity];

            for (var i = 0; i < oldCapacity; i++)
            {
                if (_table[i] != null)
                {
                    var current = _table[i];
                    while (current != null)
                    {
                        int index = GetIndex(current.Key);

                        if (newTable[index] == null)
                        {
                            newTable[index] = current;
                        }
                        else
                        {

                            var currentInNewTable = newTable[index];

                            while (currentInNewTable.Next != null)
                                currentInNewTable = currentInNewTable.Next;

                            currentInNewTable.Next = current;
                        }


                        var buf = current.Next;
                        current.Next = null;
                        current = buf;
                    }
                    _table[i] = null;
                }
            }

            _table = newTable;

        }

        private void Init()
        {
            _capacity = 16;
            _table = new Pair[_capacity];
            _count = 0;
        }

    }
}
