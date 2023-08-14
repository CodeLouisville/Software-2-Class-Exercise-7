# Software 2 - Class Exercise 7
# Goal
Learn how to add and use Dependency Injection in your projects

# Directions
1. Install the `Microsoft.Extensions.Hosting` nuget package into your project.
1. In the `Program` class, create a static method called `CreateServiceCollection`.  It will return an `IServiceProvider` and take no arguments.
1. In this method, return the following code:
    ```
    new ServiceCollection()
        
        .BuildServiceProvider();
    ```
    That empty line is where you will configure all of your services.
1.  Call this new method at the top of the `Program` class (below the using statements) and assign what it returns to a variable.
1. Back in `CreateServiceCollection`, in the empty space, add `ProductLogic` as a _transient_ service using the `AddTransient` method.  This method is an _extension_ method, so you will need to add a using statement for it.  This method is a generic method that takes 2 type parameters, the first will be the interface and the second will be the concrete class. 
1. At the top of the program class, replace the assignment of the `productLogic` varible with the following line: `services.GetService<IProductLogic>`.  `services` is the name of the variable you made in step 4, so it might be different name for you.
1. Run the program to ensure that you made the changes correctly.
