using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NotenDLL
{
    class FirstStart
    {
        string sourceFolder;
        string file;

        public FirstStart()
        {
            sourceFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/kaizi99/NotenLibrary/";
            file = sourceFolder + "settings.settings";

            if(!Directory.Exists(sourceFolder))
            {
                setup();
            }
        }

        private void setup()
        {
            Directory.CreateDirectory(sourceFolder);

            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine(92);
            sw.WriteLine(86);
            sw.WriteLine(63);
            sw.WriteLine(50);
            sw.WriteLine(25);
            sw.WriteLine(2);

            sw.Close();
        }
    }
}
