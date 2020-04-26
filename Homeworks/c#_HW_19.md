﻿##### __ISTA421__ 
##### _C#_HW19__

## *Denis Licona*
###### *18 Mar 2020* 

1. What is an *enumerable collection*?
- A collection that implements the *System.Collections.IEnumerable* interface.

2. What properties and methods does the *IEnumerable* interface contain?
- A single method *GetEnumerator()*.

3. What properties and methods does the *IEnumerator* interface contain?
- object Current { get; } bool MoveNext(); void Reset();

4. What values does the *MoveNext()* method return? What does it do?
- The MoveNext method should return true if there actually is another item and false if there isn’t.

5. What values does the *Reset()* method return? What does it do?
- You use the Reset method to return the pointer back to before the first item in the list.

5. Are *IEnumerable* and *IEnumerator* type safe? Why or why not? If not, how do you implement type safety?
- Returns an object not a type. 
- It is not type safe you must define the type in the parameter, using generics (IEnumerator<T>).

6. Why don't recursive methods retain state when used with data structures like binary trees?
- Because it only computes one value at a time and has no memory of previous values.

7. How do you define an enumerator?
- You implement Current, MoveNext and Reset to count off or name one by one items in a collection.

8. What is an *iterator*?
- An iterator is an object that enables a programmer to traverse a container, particularly lists.

9. What does *yield* do?
- You use a yield return statement to return each element one at a time. The sequence returned from an iterator method can be consumed by using a foreach statement or LINQ query.