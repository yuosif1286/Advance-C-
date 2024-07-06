## What is a Delegate in C#?
A Delegate is a Type-Safe Function Pointer. It means the delegate holds the
reference of a method or function and when we invoke the delegate, the method
it refers to is going to be executed. The delegate signature and the method it
points to must have the same signature. While creating the delegate instance,
we need to pass the method as a parameter to the delegate constructor.  Again,
there are two types of Delegates in C#. They are as follows:

1. Single Cast Delegate: Delegate Refers to a single function or method.
2. Multicast Delegate: Delegate Refers to multiple functions or methods.

We have already discussed Singlecast Delegate in our previous article.
Today, we are going to discuss Multicast Delegates in C#.

## What is Multicast Delegate in C#?
A Multicast Delegate in C# is a delegate that holds the references of more than
one handler function. When we invoke the multicast delegate, then all the functions
which are referenced by the delegate are going to be invoked.
If you want to call multiple methods using a delegate then all the method
signatures should be the same. 