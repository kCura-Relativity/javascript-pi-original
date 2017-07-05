# javascript-pi
Open Source Community: This application shows an example of how to use a Page Interaction event handler and JavaScript to connect a change event on an html element.  The code responds to a change event by dynamically showing the input box that corresponds to a choice in the drop down.  The event handler only files in edit mode on the object and there is no Pre Load event handler to set proper display if value is on field.  There is also no logic from submitting info entered into the hidden inputs.  I hope one day to turn this into a tool where you can test out JavaScript without having to create the Page Interaction event handler just to do it.

## Dynamically showing and hiding fields on a layout.
Download the RA_Javascript_PI.rap file in the deployment folder.  It is a Relativity Application which contains the compiled DLL (for the Event Handler) and the fields required for the example.
  1.	Install the application in the Application Library and eventually into a Workspace.
  2.	When in a Workspace, click the Javascript_PI tab and then the Object 1 tab.    
  3.	Click the New Object 1 button:  
  4.	On the Layout, you will notice that there is one Drop Down List box.  By selecting different choices, the associated textboxes are either displayed or hidden.


Download the Visual Studio project in the code folder.  Use the source code a reference to see how to accomplish injecting javascript into an Event Handler.
  1.	To compile the solution please make sure to add references to the following DLL’s.
  a.	kCura.EventHandler.dll
  b.	Relativity.API.dll

While this is an open source project on the kCura GitHub account, support is only available through through the Relativity developer community. You are welcome to use the code and solution as you see fit within the confines of the license it is released under. However, if you are looking for support or modifications to the solution, we suggest reaching out to a [Relativity Development Partner](https://www.kcura.com/relativity/ediscovery-resources/ecosystem).
