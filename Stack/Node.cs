﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Node<T>
    {
        public T data { get; set; }
        public Node<T>? next = null;
        public Node(T data)
        {
            this.data = data;
        }
    }
}