using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.LinkedIterator {
   
    internal class LinkedIterator<T> {
        public Node<T> Root { get; private set; }
        public Node<T> Current { get; private set; }
        //public Node<T> Next { get; private set; }
        public bool Completed {
            get {
                return Current == null;
            }
        }

        public LinkedIterator(Node<T> current){
            this.Root = current;
        }

        public T DoNext() {
            var vaule = Current.Value;
            Current = Current.Next;
            return vaule;
        }

        public T DoPrevious() {
            var vaule = Current.Value;
            Current = Current.Previous;
            return vaule;
        }

        public void Reset() {
            Current = Root;
        }

    }


    internal class LinkedList<T> {
        private Node<T> root;

        public LinkedIterator<T> LinkedIterator { get; set; }

        public void Add(T value) {
            if(root == null) {
                root = new Node<T> {Value = value };
                LinkedIterator = new LinkedIterator<T>(root);
            }
            else {
                root.Append(value);
            }
        }
    }

    internal class Node<T> {
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }
        public T Value { get; set; }

        public void Append(T value) {
            if (Next == null) { 
                Next = new Node<T>() { Value = value, Previous = this};
            }
            else {
                Next.Append(value);
            }
        }

    }
}
