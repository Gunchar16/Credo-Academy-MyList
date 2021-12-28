using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{

    public class MyList <T>
    {
        class Node<T>
        {
            public T Value { get; set; }
            public Node<T> NextNode { get; set; }
            public Node() {
                NextNode = null;
            }
            public Node(T val)
            {
                Value = val;
                NextNode = null;
            }
        }
        public int Length { get; set; }
        private Node<T> node;
        public T this[int index]
        {
            get
            {
                var tmp = node;
                int i = 0;
                while (true)
                {
                    if (i == index)
                        return tmp.Value;
                    tmp = tmp.NextNode;
                    i++;
                }
            }
            set
            {
                var tmp = node;
                int i = 0;
                while (true)
                {
                    if(i == index)
                    {
                        tmp.Value = value;
                        return;
                    }
                    tmp = tmp.NextNode;
                    i++;
                }
            }
        }
        public MyList()
        {
            Length = 0;
            node = null;
        }
        public MyList(params T[] arr)
        {
            foreach(var item in arr)
            {
                this.Add(item);
            }
        }
        public void Add(T val)
        {
            Length++;
            if(this.node == null)
            {
                this.node = new Node<T>(val);
                return;
            }
            var tmp = this.node;
            for (; tmp.NextNode != null; tmp = tmp.NextNode);
            tmp.NextNode = new Node<T>(val);
        }
        public void Remove(int index)
        {
            if(index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0)
            {
                this.node = node.NextNode;
                Length--;
                return;
            }
            int i = 1;
            var tmp = this.node;
            while(true)
            {
                if (i == index)
                {
                    tmp.NextNode = tmp.NextNode.NextNode;
                    Length--;
                    return;
                }
                i++;
                tmp = tmp.NextNode;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < Length; i++)
                sb.Append($"{this[i].ToString()}  ");
            return sb.ToString();
        }

    }
}
