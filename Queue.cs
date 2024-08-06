using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtteckServer
{
    internal class Queue<T>
    {
        private Node<T> _Head;
        private Node<T> _Tail;
        private int _Count;

        public Queue() 
        {
            this.SetHead(null);
            this.SetTail(null);
            this._Count = 0;
        }

        public void SetHead(Node<T> head)
        {
            _Head = head;
        }

        public void SetTail(Node<T> tail)
        {
            _Tail = tail;
        }

        public void setCount(int count)
        {
            this._Count = count;
        }
        public Node<T> getHead()
        {
            return this._Head;
        }

        public Node<T> getTail()
        {
            return this._Tail;
        }
        public int getCount()
        {
            return this._Count;
        }

        public void Enqueue(T valu)
        {
            Node<T> newnode = new Node<T>(valu);
            if (this.getTail() != null)
            {
                Node<T> tail = this.getTail();
                tail.SetNext(newnode);
            }
            if (this.getHead() == null)
            {
                this.SetHead(newnode);
            }
            this.SetTail(newnode);
            this.setCount(this.getCount()+1);
        }

        public T Dequeue()
        {
            if(this.isempty()) throw new Exception("queue is empty") ;
            T valu = this.getHead().GetValu(); 
            this.SetHead(this.getHead().GetNext());
            if(this.getHead()==null)
            {
                this.SetTail(null);
            }
            this.setCount(this.getCount() - 1);
            return valu;
        }

        private bool isempty() { return this.getHead() == null;}
    }
}
