using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    class element<T>
    {
        private T data;
        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        element<T> next;
        internal element<T> Next
        {
            get { return next; }
            set { next = value; }
        }
        public element(T x)
        {
            this.data=x;
            this.next = null;
        }
    }
}
