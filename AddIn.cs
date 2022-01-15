using ExcelDna.Integration;
using ExcelDna.IntelliSense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIntellisense
{
    internal class AddIn : IExcelAddIn
    {
        public void AutoClose()
        {
            IntelliSenseServer.Uninstall();
        }

        public void AutoOpen()
        {
            IntelliSenseServer.Install();
        }
    }
}
