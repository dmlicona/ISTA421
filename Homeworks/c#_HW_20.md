##### __ISTA421__ 
##### _C#_HW20__

## *Denis Licona*
###### *23 Mar 2020* 

1. What is a *delegate*? Explain delegates in terms of pointers and reference types.
- A delegate is an object that refers to method. Delegates are so named because they “delegate” processing to the referenced method when they are invoked.

2. How do you declare a delegate? Include a discussion of types, return values, names, and parameters.
- Use the delegate keyword, specify the return type, a name for the delegate and any parameters.

3. How do you create instances of delegates and assign values to the instance? What are the values?
- After you have declared the delegate, you can create an instance and make it refer to a matching method by using the += compound assignment operator.

4. How do you invoke a method that has been added to a delegate?
- You use the same syntax to invoke a delegate as you use to call a method. (pg. 454)

5. What is an *event*? Why do we have events?
- Events enable a class or object to notify other classes or objects when something of interest occurs. An event maintains a list of methods to call when it is raised. These methods are sometimes referred to as subscribers.

6. How do you declare events?
- You declare an event similarly to how you declare a field. However, because events are intended to be used with delegates, the type of an event must be a delegate, and you must prefix the declaration
with the event keyword.

7. How do delegates recognize event subscriptions? How do you unsubscribe an event from a delegate?
- You subscribe to an event by using += operator. You unsubscribe to an event by using -= operator.

8. How do you raise an event? How do you declare code that raises an event?
- You can raise an event by calling it like a method. When you raise an event, all the attached delegates are called in sequence.

9. Explain with specificity what happens when an event fires and that event has been attached to a delegate.
- All methods that are assigned to the event run.