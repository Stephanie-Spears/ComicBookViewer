##### ViewBag
Model object is used to send data in a razor view. However, if you only want to send a small amount of temporary data to the view, you can use ViewBag.
Viewbag is useful if you want to transfer temporary data (which is not included in a model) from the controller to the view. The viewBag is a dynamic type property of the ControllerBase class (which is the base class of all controllers).
Ex: 
```CSharp
//Controller
ViewBag.Name = "Kali"; //this attaches the Name property to ViewBag with dot notation and assigns a string value. 
//View
@ViewBag.Name //the value set in the controller can be accessed in the view using the @ symbol, which is the razor syntax to access the server-side variable.
```
ViewBag only transfers data from the controller to the view, not visa-versa. If attempted, ViewBag values will be null.
##### Partial Views
Partial views are a reusable view which can be used as a child view in other views. Can be used in the Layout view, as well as other content views. 