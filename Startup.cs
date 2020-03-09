using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FriendLetter
{
  public class Startup
  {
    //This constructor will create an iteration of the Startup class that contains specific settings and variables to run our project successfully. It's required for configuring a basic ASP.NET Core MVC project.

    public Startup(IHostingEnvironment env)
    {
      var builder = new ConfigurationBuilder()
          .SetBasePath(env.ContentRootPath)
          .AddEnvironmentVariables();
      Configuration = builder.Build();
    }

    //This line is the process of adding custom configurations to our project.
    public IConfigurationRoot Configuration { get; }

    //ConfigureServices() is a required built-in method used to set up an application's server. We can use it to configure other framework services.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();
    }

    //The Configure() method is built-in and required in all ASP.NET Core apps. ASP.NET calls Configure() when the app launches. It's responsible for telling our app how to handle requests to the server.
    public void Configure(IApplicationBuilder app)
    {
      //This will produce a friendly error report when Razor fails to load.
      app.UseDeveloperExceptionPage();

      //app.UseMvc(...), tells our app to use the MVC framework to respond to HTTP requests. This block of code also sets up default routing for our application. It tells the project to use the Index action of the Home Controller as the default route. This will be our homepage. 
      app.UseMvc(routes =>
      {
          routes.MapRoute(
              name: "default",
              template: "{controller=Home}/{action=Index}/{id?}");
      });
      //app.Run(...), is not actually required to successfully launch our project. However, it will allow us to test that our Configure() method is working properly.
      app.Run(async (context) =>
      {
          await context.Response.WriteAsync("Hello World!");
      });

    }
  }
}
