using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsoftAcPlugin
{
    public class Plugin
    {
        [CommandMethod("ConcentricCircles")]
        public static void ConcentricCircles()
        {
            //create and show the form 
            var form = new PluginForm();
            form.Show();
        }
    }
}
