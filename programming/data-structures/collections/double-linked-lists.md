# Double Linked Lists

Double Linked Lists are an extension of the Linked List data structure.
Have a read of our [Introduction to Single Linked Lists](...) if you're not familiar with them.

Single Linked Lists only have a single pointer, which points to the next node in the list. 
This means that you can only traverse the list in one direction, starting at the head and following the pointers to the tail. 
If you want to traverse the list in the opposite direction, you have to start at the head again and follow the pointers backwards, which can be time-consuming and inefficient.

Double Linked Lists, on the other hand, have two pointers per node: 
- One that points to the next node in the list (as in Single Linked Lists)
- Another that points to the previous node in the list. 

This allows you to traverse the list in both directions, from head to tail and from tail to head, without having to start at the head again.

To illustrate this concept, let's take a look at a simple example. 
Suppose we are creating a list that stores the names of some people. 
If we stored it as a Single Linked List, it would look like this:

```
Alice -> Bob -> Charlie -> Dave -> {NOTHING}
```

If we created it as a Double Linked List, it would look like this:

```
{NOTHING} <- Alice <-> Bob <-> Charlie <-> Dave -> {NOTHING}
```

In this example, Alice is the first node in the list, and Dave is the last node. 
Each node has a data value (the person's name) and two pointers: one to the next node in the list and one to the previous node in the list. 
The pointer to the next node is represented by an arrow pointing to the right, and the pointer to the previous node is represented by an arrow pointing to the left.

To access an element in the Double Linked List, you can start at either end of the list and follow the pointers in the appropriate direction until you reach the desired node. 
For example, if you want to find the last name in the list (Dave), with a Single Linked List, you would have to start at the head and follow the pointers to the right until you reach Dave. 
But with a Double Linked List, you can start at the tail and immediately find the correct name.

Because of the extra effeciency of being able to traverse in both directions, Double Linked Lists are often used to implement data structures like stacks and queues, which require efficient insertion and deletion of elements at both ends of the list. 

Of course, this extra functionality comes at a price, which is that we have to store more data (double the amount of pointers) for the list. 
For large lists where traversing in both directions is rare or unncessary, this make them a worse choice than Single Linked Lists.
If you're coding them from scratch, they are also more complicated to create and manage than Single Linked Lists.




