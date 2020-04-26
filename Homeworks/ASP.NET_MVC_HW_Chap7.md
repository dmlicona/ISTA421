##### __ISTA421__ 
##### ASP.NET MVC_Ch. 7

## *Denis Licona*
###### *24 Mar 2020* 

1. There are many kinds of tests, including Unit Tests. What is a unit test, and what does it enable you to do?
- Unit testing is a form of testing in which individual components are isolated from the rest of the application so their behavior can be thoroughly validated. It is used to validate the behavior of individual components and features in an application.

2. What is the primary benefit of using unit tests?
- Verifies that the result was the one that was expected.

3. What is the purpose of using method __GetHashCode()__ when using __Assert.Equal()__?
- This method asserts that the result is equal to the expected outcome. To create a hashed value usually used for comparison to like values.

4. The book states: "The chain of dependencies can make it difficult to understand what causes a test to fail." Why is this statement true?
- Makes it difficult to figure out which part of the application is the problem if there are too many dependencies. It is hard to determine of the failure is caused by the current test, or a problem with one of the dependencies.  Loose coupled applications are easier to test. 

5. How do unit tests isolate small parts of an application?
- By using the AAA pattern for a method under test.
- The __Arrange__ section of a unit test method initializes objects and sets the value of the data that is passed to the method under test.

- The __Act__ section invokes the method under test with the arranged parameters.

- The __Assert__ section verifies that the action of the method under test behaves as expected.

6. According to the book, what is the key to isolating components?
- Creating interfaces.

7. Briefly discuss the nature and purpose of a *fake implementation* of a class. What does a fake implementation do that a real implementation cannot do?
- Isolating components effectively requires fake implementations of classes to provide test data or to check that a component behaves the way it should.

8. What is *test driven development*? What is the development cycle for test driven development? This is not in the book.
- TDD is a software development process that relies on the repetition of a very short development cycle: requirements are turned into very specific test cases, then the code is improved so that the tests pass. RADIT (Requirements, analysis, Design, Integration, Test). 

9. What are *parameterized tests* and why would we want to use them?
- The data used in a test is removed from the test so that a single method can be used for multiple tests.

10. What is a *mocking framework*? What is the difference between a fake object and a mock object?
- A mocking framework makes it easier to create fake components to isolate parts of the application for unit testing. Creating fake objects gets out of hand, and the best way to get things back under control is to use a fakes framework, also known as a mocking framework. The purpose of mocking is to isolate and focus on the code being tested and not on the behavior or state of external dependencies.

11. (Optional) Can you think of one very important drawback to writing unit tests?
- Time. cyclomatic complexity, excessive possible paths to test.