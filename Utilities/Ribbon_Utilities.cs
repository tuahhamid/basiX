using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiX.Utilities
{
    public static class Ribbon_Utils
    {
        public static Result AddRibbonTab(UIControlledApplication uiCtlApp, string tabName) 
        {
            try
            {
                uiApp.CreateRibbonTab(tabName);
                return Result.Succeeded;
            }
            catch 
            {
                Debug.WriteLine($"ERROR: Could not create tab {tabName}");
                return Result.Failed;
            }
        }   
    }
}
