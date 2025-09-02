using Autodesk.Revit.UI;

// this application belongs to the root namespace
namespace basiX
{
    // implementing the interface for applications
    public class Application: IExternalApplication
    {
        // method called at Revit startup
        public Result OnStartUp(UIControlledApplication uiCtlApp)
        { 
            var ctlApp = uiCtlApp.ControlledApplication;
            return Result.Succeeded;
        }

        // method called at Revit shutdown
        public Result OnShutDown(UIControlledApplication uiCtlApp)
        { 
            return Result.Succeeded;
        }
    }
}