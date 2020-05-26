using System;
using lista;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private void doTestNode(int value, Node expectedNode)
        {
            Node node = new Node(value, null);
            Assert.IsTrue(node._value == expectedNode._value);
        }

        [TestMethod]
        public void TestNode()
        {
            int value = 1;
            Node nodo = new Node(value, null);

            doTestNode(value, nodo);
        }

        private void doTestAddNode(NodeList nodeList, int nodeCount)
        {

            int currentCount = 0;

            if (nodeList != null)
            {
                currentCount = 1;

                var currentNode = nodeList.listaNodi;
                while (currentNode._next != null)
                {
                    currentCount++;
                    currentNode = currentNode._next;                    
                }               
            }
            Assert.IsTrue(currentCount == nodeCount);
        }

        [TestMethod]
        public void TestAddNode()
        {
            int value = 1;
            Node first = new Node(value, null);
            Node second = new Node(value + 1, null);
            Node third = new Node(value + 2, null);

            var lista = new NodeList();
            doTestAddNode(null, 0);
            lista.Insert(first);
            doTestAddNode(lista, 1);
            lista.Insert(second);
            doTestAddNode(lista, 2);
            lista.Insert(third);
            doTestAddNode(lista, 3);

        }

        private void doTestPrintNodeList(NodeList nodeList, string expectedValues)
        {
            string listaValori = nodeList.PrintNodeList();

            Assert.IsTrue(listaValori == expectedValues);
        }

        [TestMethod]
        public void TestPrintNodeList()
        {
            int value = 1;
            Node first = new Node(value, null);
            Node second = new Node(value + 1, null);
            Node third = new Node(value + 2, null);

            var lista = new NodeList();
            string expectedValues = "";
            doTestPrintNodeList(lista, expectedValues);

            lista.Insert(first);
            expectedValues = "1";
            doTestPrintNodeList(lista, expectedValues);

            lista.Insert(second);
            expectedValues = "12";
            doTestPrintNodeList(lista, expectedValues);

            lista.Insert(third);
            expectedValues = "123";
            doTestPrintNodeList(lista, expectedValues);

        }
    }
}
