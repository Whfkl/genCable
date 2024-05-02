using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genCable
{

    public class MainClass
    {

        


        [CommandMethod("genCable")]
        public void Main()
        {
            Form1 form = new Form1();
            Autodesk.AutoCAD.ApplicationServices.Application.ShowModelessDialog(form);
        }
        public void DataProcess()
        {
            
        }
    }
}
