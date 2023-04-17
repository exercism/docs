# Linked Lists

Linked Lists are an essential data structure in computer science. 
They are used to store and manage collections of data, where each element in the collection is connected to the next element through a "link". 

Imagine that you have a set of books, and you want to organize them in a way that you can easily access them one by one. 
One way to do this is to stack them on top of each other. 
However, this approach has some limitations. 
If you want to access a book from the middle of the stack, you would have to remove all the books on top of it. 
Additionally, if you want to insert a new book in the middle of the stack, you would have to move all the books on top of the insertion point.

This is where Linked Lists come in. 
A Linked List is like a chain of items, where each item (or "node") has a data value and a pointer to the next node in the chain. 
This allows you to access any item in the list without having to traverse all the previous items.

To illustrate this concept, let's take a look at a simple example. 
Suppose we have a Linked List that stores the names of some people:

```
Alice -> Bob -> Charlie -> Dave -> {NOTHING}
```

In this example, Alice is the first node in the list, and Dave is the last node. 
Each node has a data value (the person's name) and a pointer to the next node in the list. 
The pointer to the next node is represented by an arrow.

To access an element in the Linked List, you start at the first node (Alice) and follow the pointers until you reach the desired node. 
For example, if you want to access the third node (Charlie), you would start at the first node and follow the pointers to the next two nodes until you reach Charlie.

Linked Lists are particularly useful when you need to insert or delete items in the middle of the list. 
To insert a new node in the middle of the list, you simply create a new node with the data value you want to insert, and update the pointers of the adjacent nodes to point to the new node. 
To delete a node from the list, you update the pointers of the adjacent nodes to skip over the node you want to delete.

In summary, Linked Lists are a flexible and powerful data structure that allows you to store and manage collections of data in a practical and efficient way. They are particularly useful when you need to insert or delete items in the middle of the list.
