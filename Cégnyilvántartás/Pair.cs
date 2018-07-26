using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cégnyilvántartás
{
    
    class Pair<T,K>
    {
        delegate void Fire(bool item);



        List<T> _innerStore;
        int _currentIndex;
        public T Item1 { get
                
                ; }
        public K Item2 { get; }
    

        public Pair(T item , K item2)
        {
            Item1 = item;
            Item2 = item2;
        }

        public T Get(int index)
        {
            if (index >= _currentIndex)
            {
                throw new ArgumentOutOfRangeException();
            }    
            return _innerStore[index];
        }


    }

}

