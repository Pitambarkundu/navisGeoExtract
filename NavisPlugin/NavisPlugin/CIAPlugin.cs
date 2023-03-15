using System;
using Autodesk.Navisworks.Api;
using Autodesk.Navisworks.Api.Plugins;
using Autodesk.Navisworks.Api.DocumentParts;
using System.Windows.Forms; //Add reference through Solution Explorer and in Assemblies Framework find the form 

namespace NavisPlugin
{   
    [Plugin("NavisPlugin","CONN",DisplayName ="Navis Plugin")]
    public class CIAPlugin: AddInPlugin //Inheriting the class AddInPlugin
    {
        public override int Execute(params string[] parameters)
        {
            var newapp = Autodesk.Navisworks.Api.Application.ActiveDocument;
            var dg = new OpenFileDialog();

            if (dg.ShowDialog() == DialogResult.OK)
                try
                {
    
                        //var newapp = new Autodesk.Navisworks.Api.Automation.NavisworksApplication();
                        newapp = Autodesk.Navisworks.Api.Application.ActiveDocument;
                        newapp.AppendFile(dg.FileName);
                }

                catch (Exception exception)
                {
                    MessageBox.Show("Error", "Execute", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            return 0;
        }


    }
}
