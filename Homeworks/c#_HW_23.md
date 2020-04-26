##### __ISTA421__ 
##### _C#_HW23__

## *Denis Licona*
###### *19 April 2020* 

1. List two reasons for multitasking, and explain the rationale for them.
- To improve responsiveness by being able to handle more than one task at a time.
- To improve scalability by creating more instances of task running in parallel.
- Able to run the same program's task at the same time. 

2. Explain Moore's law. What does Moore's law have to do with multitasking?
- Moore's laws talks about how computer chips amount of transistors double every two years making for faster connections. This speeds up multitasking by completing processes faster as the price of chips has dropped so you can have multiple in a computer. To make the best use of multicore processors,
you need to write your applications to take advantage of multitasking, so that all processors are being used and not seating idle. 

3. In UWP, what namespace is used as the container for the multitasking methods
- system.threading.task

4. What is the difference between tasks and threads? Explain.
- The Task class is an abstraction of a concurrent operation. You create a Task object to run a block of code. A task can have multiple processes happening at the same time. Threads can only have one task running at a time. 

5. What is the ThreadPool?
- Provides a pool of threads that can be used to execute tasks, post work items, process asynchronous I/O, wait on behalf of other threads, and process timers. IT implements a number of optimizations and work stealing algorithms to schedule threads successfully.

6. What parameters does the Task() constructor take?
- an action delegate: a method that does not return a value

7. How do you start a thread?
- using the task.run method passing it an action delegate to the task constructor

8. What is the difference between the Start() and Run() methods?
- start is used after created an class and signals when to start the task while run will start the task immediately. When a program calls the start() method, a new thread is created and then the run() method is executed. But if we directly call the run() method then no new thread will be created and run() method will be executed as a normal method call on the current calling thread itself and no multi-threading will take place.

9. What is the difference between creating independent tasks with Tasks and paralleliztion with Parallel? Explain.
- task you have complete control and control the number of task the application creates you synch the code to run while parallel class creates its own set of task and synch them automatically.

10. Explain how manual cancellation works using a cancellation token.
- a structure that represents a request to cancel one ore more task. It has a boolean property isCancledRequested that a task checks periodically and if true cancels.