using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  //By adding : Controller to our HomeController class, we tell .NET that HomeController should inherit or extend functionality from ASP.NET Core's built-in Controller class that we import with our using statement.
  public class HomeController : Controller
  {
    //The Hello() method represents a route in our application. -> Route definition: The path consists of one or more segments separated by slashes. It provides a name for identifying the specific resource requested. 
    
    //Our current route would look something like this: www.learnhowtoprogram.com/home/hello and the path would be the /home/hello section -> The first part of the path /home corresponds to the name of our controller HomeController and the second part /hello corresponds to the name of our route method Hello()

    //The route decorator [Route("/hello")] provides additional information to a route we define. In our case, the decorator is overriding the default URL path that corresponds to each of the two routes.

    //Instead of needing to visit /home/hello to activate our Hello() route, we now only have to visit /hello. Similarly, instead of visiting /home/goodbye to invoke Goodbye(), the URL localhost:5000/goodbye will now invoke this route.

    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    //The return type of our Letter() method is now an ActionResult, not a string. This is a built-in MVC class that handles rendering views.
    
    //Our Letter() route creates a new variable of type LetterVariable, saves a name in its Recipient property, and then passes the variable into the view. This ensures our corresponding Letter.cshtml view now has access to our LetterVariable object.

    //Our method returns another method called View(). This is a built-in method from the Microsoft.AspNetCore.Mvc namespace. When our route is invoked, it will return a view.

    //Our application is using what's called model binding to pass data from one part of an application to another.Because instances of @Model in the view represent the argument we've passed into the View() method, @Model.Recipient is the same as calling myLetterVariable.Recipient.

    [Route("/")]
    public ActionResult Letter() {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Tim";
      myLetterVariable.Sender = "Ben";
      return View(myLetterVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      return View(myLetterVariable);
    }
  }
}