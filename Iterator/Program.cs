// See https://aka.ms/new-console-template for more information
using Iterator;

Console.WriteLine("Hello, World!");

List<int> ints = new List<int>();
ints.Add(1);
ints.Add(2);

LinkedList<int> ints1 = new LinkedList<int>();
var node1 = ints1.AddFirst(1);
var node2 = ints1.AddLast(2);
ints1.AddAfter(node1, 3);


