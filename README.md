<b>Objective :</b> To convert a C# Console Project(asp.net core)to Web Application.

<pre>
Step 1: Select Console Application,which is a command line application that can run on .NET Core (C#).
</pre>
<pre>
Set 2: Select a target framework. In this project .NET Core 3.1 has been chosen.
</pre>
<pre>
Step 3: After creating the project, right click on the project from the left hand <br> side plane and select the option "Edit Project File"(projectname.csproj).
</pre>
<pre>
Step 4: In the sdk attribute convert the Microsoft.NET.Sdk to Microsoft.NET.Sdk.Web to make it a web application.
Also remove the <b>OutputType</b> tag.
</pre>
<pre>
Step 5: Then you need to create host using the interface IHostBuilder. <br> (A host is an object that encapsulates an app's resources such as Dependency Injection (DI), Logging, Configuration, <br> IHostedService implementations)( IHostBuilder, CreateHostBuilder, CreateDefaultBuilder, <br> ConfigureWebHostDefaults, UseStartup<Startup> CreateHostBuilding(args).Build().Run().  
</pre>
<pre>
Step 6: Then setup the routing and endpoints and mapping(IApplicationBuilder app, <br> IWebHostEnvironment env, app.UseRouting, app.UseEndpoints, endpoints.MapGet)
</pre>
<pre>
Step 7: Run the app (Windows: F5, Mac: Shift+enter), it will open in the browser.
</pre>
