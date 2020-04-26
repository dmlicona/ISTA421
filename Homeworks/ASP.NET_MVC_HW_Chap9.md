##### __ISTA421__ 
##### ASP.NET MVC_Ch. 9

## *Denis Licona*
###### *7 April 2020* 

1. In the __Configure()__ method of the Startup.cs file, note the four map routes defined in the book. (1) What is the difference in the definitions of the four routes defined? (2) How are the routes ordered? (3) Why does it matter that the routes are ordered this way?
- The Configure method is used to specify how the app responds to HTTP requests. The request pipeline is configured by adding middleware components to an IApplicationBuilder instance. IApplicationBuilder is available to the Configure method, but it isn't registered in the service container. Hosting creates an IApplicationBuilder and passes it directly to Configure.

2. When you define tag helpers, you can specify a prefix for the attribute name. (1) What happens when you define several attributes with the same prefix? (2) What is the benefit of doing this?
- Defining several attributes with the same prefix allows us to specify a prefix for attribute names of the elements to be added into a collection. 

3. How does using the attribute page-url-category benefit the application? Be specific with your answer and give an example.
- The current category will be passed to the List action method, and the filtering will be preserved.

4. What is a *view component* and what purpose do view components have in building a web application?
- A view component is a C# class that provides a small amount of reusable application logic with the ability to select and display Razor partial views.

5. The book notes that you can build a list of categories programatically or use the "more expressive Razor syntax" to render the HTML. What do you think that this means?
- one of the benefits of working with view components is they can render Razor partial views. That means I can use the view component to generate the list of components and then use the more expressive Razor syntax to render the HTML that will display them.

6. What does @await Component.InvokeAsync("InformationSidebar") do?
- Returns a partial view of the InformationSidebar.

7. Describe the functionality of the RouteData property of the ViewComponent class, and give a concrete example of that functionality.
- One of the properties is called RouteData, which provides information about how the request URL was handled by the routing system. RouteData property accesses the request data in order to get the value for the currently selected category.

8. What is the purpose of *session state*, and how does the Sports Store application use session state?
- Session state associates data with a session. The store details of a user’s cart using session state, which is data that is stored at the server and associated with a series of requests made by a user.

9. Describe *model binding* and give a specific example. Explain how model binding relates form elements, HTTP query requests, variables, and properties.
- Model binding is a mechanism used to create parameter objects defined in controller action methods.

10. What does the __RedirectToAction()__ method do?
- This has the effect of sending an HTTP redirect instruction to the client browser, asking the browser to request a new URL.