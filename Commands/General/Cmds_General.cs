using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI;

// Associate with general commands
namespace basiX.Cmds_General
{
    /// <summary>
    /// Example command class
    /// </summary>
    [Transaction(TransactionMode.Manual)]
    public class Cmd_Tes1t : IExternalCommand 
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            //Collect the document
            UIApplication uiApp = commandData.Application;
            UIDocument uiDoc = uiApp.ActiveUIDocument;
            Document doc = uiDoc.Document;

            //code logic

            //TaskDialog.Show("basiX", "Hello from basiX!");
            return Result.Succeeded;
        }
    }
    public class Cmd_Test2 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            //Collect the document
            UIApplication uiApp = commandData.Application;
            UIDocument uiDoc = uiApp.ActiveUIDocument;
            Document doc = uiDoc.Document;

            //code logic

            //TaskDialog.Show("basiX", "Hello from basiX!");
            return Result.Succeeded;
        }
    }
}