using System;
using System.Collections.Generic;
using System.Text;

namespace lista
{
    public class Node
    {
        public int _value;

        public Node _next;

        public Node(int value, Node next)
        {
            this._value = value;
            this._next = next;
        }
    }

    public class NodeList
    {
        public Node listaNodi;

        public NodeList()
        {

        }

        public void Insert(Node nuovoNodo)
        {
            if (listaNodi == null)
                listaNodi = nuovoNodo;
            else
            {
                var currentNode = listaNodi;
                while (currentNode._next != null)
                {
                    currentNode = currentNode._next;
                }
                currentNode._next = nuovoNodo;
            }            
        }

        public string PrintNodeList()
        {
            string lista = "";

            if (listaNodi == null)
                return lista;
            else
            {
                var currentNode = listaNodi;
                lista = currentNode._value.ToString();

                while (currentNode._next != null)
                {
                    currentNode = currentNode._next;
                    lista += currentNode._value.ToString();
                }

            }

            return lista;
        }
    }
}
