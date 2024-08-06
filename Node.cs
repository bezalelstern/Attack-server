using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AtteckServer
{
    internal class Node<T>
    {
        private T _Valu;
        private Node<T> _next;

        //public Node() 
        //{
        //    this.SetValu(null);
        //    this.SetNext(null);
        //}

        public Node(T valu, Node<T> next)
        {
            this.SetValu(valu);
            this.SetNext(next);
        }

        public Node( T valu) 
        {
            this.SetValu(valu);
        }

        public T GetValu()
        {
            return this._Valu;
        }

        public Node<T> GetNext()
        {
            return  this._next;
        }

        public void SetValu( T valu)
        {
            _Valu = valu;
        }

        public void SetNext( Node<T> next)
        {
            _next = next;
        }

        public string Tostring()
        {
            string hasnext = this.GetNext() != null ? "hes" : "no";

            //string isnext;
            //if (node._next == null)
            //{
            //    isnext = "no next";
            //}
            //else { isnext = "ther is next"; }

            return $"Node value is: {this._Valu}. {hasnext} next";
        }
    }
}
