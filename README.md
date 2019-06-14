
# Mediator Pattern In .NET Core

The Mediator Pattern takes care of the interactions between different objects, providing a mediator class that coordinates all the interactions between the objects, aiming to decrease the coupling and the dependency between them and facilitating the maintenance.

Therefore, no object directly talks to another - always an object will use the mediator class to talk indirectly with other objects.

For example, consider the following scenario:

![alt text](https://static.imasters.com.br/wp-content/uploads/2019/05/30103930/0114.jpg)

Object A, needs to talk to Object B and also to Object C. However, Object A does not know the other two; therefore, Object A sends a message to the mediator which, in turn, sends to Object B and C.

With this pattern, each object has a single responsibility and can communicate with other objects without the need to know them, that is, each object, works independently and isolated, and there is no coupling between them.

Benefits
--------
1. Decoupling between objects, since no object is known in communication
2. The communication flow is centralized. As a result, changes in the mediator do not affect their listeners.
3. Changes can be easily applied to objects because they are independent
Disadvantages
1. Depending on the amount of information to be processed, the mediator may become the application bottleneck
2. Higher code complexity

What is MediatR? Why use it?
----------------------------
MediatR, as said before, is a library created by Jimmy Bogard (creator of AutoMapper), which facilitates the implementation of Mediator Pattern.

With it, we do not have to worry about developing the mediating class of communication between objects, since it provides ready-to-use interfaces, reducing the complexity of the code.

In addition, this library brings CQRS concepts into our code.

CQRS
----
Command Query Responsibility Segregation, or CQRS, is a standard software development architecture that consists of separating reading and writing into two models: Query and Command , one for reading and the other for writing data, respectively.

In our project we will use a little of this concept, however, we will not delve into it, because it is not the purpose of this article.

Links
-----
[Mediator Pattern com MediatR – ASP.NET Core 2.2](https://imasters.com.br/back-end/mediator-pattern-com-mediatr-asp-net-core-2-2)
