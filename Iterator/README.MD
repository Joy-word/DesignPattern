## 链表
单链表，双链表，循环链表...
~~~
//简单 单链表

public class MyNode<T> {
    public MyNode<T> Next { get; set; }
    public T Data { get; set; }
}

public class MyNodeList<T> {
    MyNode<T> Head { get; set; }
    void AddAfter(MyNode<T> node, MyNode<T> newNode) {
        newNode.Next = node.Next;
        node.Next = newNode;
    }

    void Append(T data) {
        MyNode<T> myNode = new MyNode<T>() { Data = data};
        var current = Head;
        while(current.Next != null) {
            current = current.Next;
        }
        AddAfter(current, myNode);
    }

}

~~~


## C# 中的数组，List，LinkedList
特征：

* 数组不会自动扩容
* List 可以自动扩容，但其不是链表，只是对数组封装了 Add 操作
* LinkedList 是真正的链表，且是一个双链表

## 迭代器
* 迭代器模式提供一种方法可以顺序访问聚合对象中各个元素，但又不暴露该对象的内部表示。
* 迭代器不一定非要用链表，数组也可以。

~~~
    public interface ILinkedIterator<T> {
        T Root { get; set;}
        T Current { get; set; }
        bool Completed { get; set; }

        T DoNext();
        T DoPrevious();
    }
~~~

## 撤销恢复
https://github.com/KirillOsenkov/Undo
