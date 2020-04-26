##### __ISTA421__ 
##### ASP.NET MVC_Ch. 8

## *Denis Licona*
###### *31 Mar 2020* 

1. What is the purpose of the __Startup__ class in an MVC application?
- The Startup class is responsible for configuring the ASP.NET Core application.

2. What is the purpose of the __ConfigureServices()__ method?
- The ConfigureServices method is used to set up shared objects that can be used throughout the application through the dependency injection feature.

3. What is the purpose of the __AddMvc()__ method?
- The AddMvc method that I call in the ConfigureServices method is an extension method that sets up the shared objects used in MVC applications.

4. What does the book describe as the "heart of an MVC application?" Why do you think that this "heart" is the starting point of all applications?
- All projects start with the domain model, which is the heart of an MVC application.

5. What is the purpose of the __Queryable<T>__ interface? What does it allow you to do?
- This interface uses IQueryable to allow a caller to obtain a sequence of Product objects.

6. How does the book describe __loosely coupled components__? Why is this an important principle of software design?
- It means that you design components independent from each other, meaning you can make a change in one part of the application without having to make corresponding changes elsewhere.

7. What, specifically, does the __AddTransient()__ method do?
- The AddTransient method specifies that a new FakeProductRepository object should be created each time the IProductRepository interface is needed.

8. Describe __dependency injection__. What is the __dependency__? What does it mean to say that it is __injected__?
- This is known as dependency injection, and its approach allows the ProductController constructor to access the application’s repository through the IProductRepository interface without having any need to know which implementation class has been configured.

9. What is the purpose of a __shared layout__?
- Shared layouts are a useful way of ensuring that views are consistent and contain important JavaScript files and CSS style sheets.

10. What is a __database context class__? What purpose does it serve?
- The database context class is the bridge between the application and Entity Framework Core and provides access to the application’s data using model objects.

11. What function does the __EnsurePopulated()__ method perform?
- The static EnsurePopulated method receives an IApplicationBuilder argument, which is the interface used in the Configure method of the Startup class to register middleware components to handle HTTP requests, and this is where I will ensure that the database has content.

12. What is a __ViewModel__? How does a ViewModel differ from an ordinary model?
- View model class, is used specifically to pass data between a controller and a view.

13. Describe in your own words a __composable URL__. Note that it is not an answer to this question to say that it is one that makes sense to a user.
- Composable infrastructures create pools of virtualized resources that are automatically composed in near real time to meet compute needs.

14. What is a __partial view__? Illustrate the concept of a partial view with an example other than the one used in the book.
- partial view, which is a fragment of content that you can embed into another view, rather like a template.