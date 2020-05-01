##### __ISTA421__ 
##### ASP.NET MVC_Ch. 12

## *Denis Licona*
###### *30 April 2020* 

Summary From your reading, select five major points that you think are the most important points covered in the chapter. For each point, write a summary of the topic. Summary means a good explanation, not just a few words or one sentence, but also not a three page paper. A good paragraph is sufficient. Write your summary as if you wanted to explain the topic to a good friend or your grandmother. Question After you complete your summary, write a concise question that will elicit a response indicating that the person answering the question understands the topic. The idea is that your question could be a test question on an examination, and that your summary could be the \correct" answer. Format Format your homework in MarkDown. Add and commit it to your local git repository, and push the homework up to your Github repository.

Topics

1. MODEL
Model represents domain specific data and business logic in MVC architecture. It maintains the data of the application. Model objects retrieve and store model state in the persistance store like a database. Model class holds data in public properties. All the Model classes reside in the Model folder in MVC folder structure.

2. VIEW
partial view - shows a portion of the view content. its a modular view, its something you can plug in. View is a user interface. View displays data from the model to the user and also enables them to modify the data. ASP.NET MVC views are stored in Views folder. Different action methods of a single controller class can render different views, so the Views folder contains a separate folder for each controller with the same name as controller, in order to accommodate multiple views.

3. CONTROLLER
A controller is responsible for controlling the way that a user interacts with an MVC application. A controller contains the flow control logic for an ASP.NET MVC application. USER -accesses-> CONTROLLER -accesses-> the MODEL(C# class: methods, controllers, builds) the MODEL then --changes/runs logic--> and comes back to the CONTROLLER CONTROLLER --updates in HTML--> the VIEW -takes the output--> returns to USER

4. ACTION METHOD
An action method looks for a view file with the same name / cshtml extension. An action method goes to the index.cshtml. usually followed by object initializer syntax which creates an anonymous object.Action is also a delegate type defined in the System namespace. An Action type delegate is the same as Func delegate except that the Action delegate doesn't return a value. In other words, an Action delegate can be used with a method that has a void return type.

5. Interface
Interface is an abstraction that separates the what from the how. the purpose of the start up class, default route is home/index, name of the file that returns html. index.csh.html. a type definition similar to a class, except that it purely represents a contract between an object and its user. It can neither be directly instantiated as an object, nor can data members be defined. So, an interface is nothing but a collection of method and property declarations.