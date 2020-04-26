##### __ISTA421__ 
##### _C#_HW22__

## *Denis Licona*
###### *12 April 2020* 

1. Explain the difference between the concepts of _associativity_ and _precedence_.
-Precedence is the order in which something is evaluated against other operators while associativity is the order in which the problem itself is calculated where right to left or left o right.

2. Explain the difference between the concepts of _binary_ and _unary_ operators.
- A unary operator has one operand while a binary operator has two. The minus sign between 5 and 6 is binary operator which requires two operands(-5 and 6 here). The minus sign in -11 is an unary operator.

3. List four constraints imposed by C# with respect to operator overloading.
- You cannot change the precedence and associativity of an operator
- You cannot invent new operator symbols
- You can’t change the meaning of operators when they are applied to built-in types.
- You can’t overload the dot (.) operator,

4. What is the syntax for overloading operators? Discuss access, scope, return value types, and parameter types and multiplicity.
- The operator is public.The operator is static. Operators cannot use the virtual, abstract, override, or sealed modifiers.A binary operator has two explicit arguments, and a unary operator has one explicit argument. at least one of the parameters must always be of the containing type.

5. What are _symmetric_ overloaded binary operators and how do they differ from non-symmetric overloaded binary operators?
- Symmetric is having binary operators of the same type on both sides.

6. Can you overload compound assignment operators(i.e. a+= b)? If so, please state how you do so. If not, explain why not.
- Yes if the first operator in the order of associativity has the same type has a method with the second type as a parameter.If you have overloaded the appropriate simple operator, the overloaded version is automatically called when you use its associated compound assignment operator. This can not be done if it doesn't have the type in it.

7. What is the difference between overloading increment and decrement operators for value types and reference types?
- Value types it works on changing the original value while reference types it changes the a copy but not the original.

8. Why do we overload some operators in pairs?
- The operand will call for it and can not be evaluated with out it.

9. What is the difference between _widening conversion_ and _narrowing conversion_?
- widening conversion because the result is wider than the original value—it contains at least as much information as the original value, and nothing is lost. a narrowing conversion because the result is narrower than the original value (that is, it can contain less information) and can throw an OverflowException exception if the resulting value is out of the range of the target type.
- int i; float f; i = 42; 
- f = i (widening) f contains [42.0]
- f = 2.718281828904590; (e) 
- i = f; Can't do this! 
- i = (int) f; i contains [2];

10. What is the difference between _explicit conversion_ and _implicit conversion_?
- When declaring your own conversion operators, you must specify whether they are implicit conversion operators or explicit conversion operators. If the conversion operator had been declared with explicit, the explicit conversion operator requires a cast. 
 - f = 2.718281828904590; (e) 
- i = f; Can't do this! 
- i = (int) f; i contains [2]; (explicit conversion)