using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NotenDLL
{
    class Settings
    {
        public Settings()
        {
            loadSettings();
        }

        float p1, p2, p3, p4, p5;

        string file;
        string sourceFolder;

        private void loadSettings()
        {
            //AppData Folder einstellen
            sourceFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/kaizi99/NotenLibrary/";

            //Datei auswählen
            file = sourceFolder + "settings.settings";
            StreamReader sr = new StreamReader(file);

            //Prozentzahlen auslesen
            p1 = float.Parse(sr.ReadLine());
            p2 = float.Parse(sr.ReadLine());
            p3 = float.Parse(sr.ReadLine());
            p4 = float.Parse(sr.ReadLine());
            p5 = float.Parse(sr.ReadLine());

            sr.Close();
        }

        public int[] getProzentwerte()
        {
            int[] Prozentwerte = new int[5];

            Prozentwerte[0] = (int)p1;
            Prozentwerte[1] = (int)p2;
            Prozentwerte[2] = (int)p3;
            Prozentwerte[3] = (int)p4;
            Prozentwerte[4] = (int)p5;

            return Prozentwerte;
        }

        public void prozentwertSpeichern(int p1, int p2, int p3, int p4, int p5)
        {
            int[] Prozentwerte = new int[5];

            Prozentwerte[0] = (int)p1;
            Prozentwerte[1] = (int)p2;
            Prozentwerte[2] = (int)p3;
            Prozentwerte[3] = (int)p4;
            Prozentwerte[4] = (int)p5;
            int Language = 0;

            StreamReader sr = new StreamReader(file);
            sr.ReadLine();
            sr.ReadLine();
            sr.ReadLine();
            sr.ReadLine();
            sr.ReadLine();
            Language = int.Parse(sr.ReadLine());

            sr.Close();

            StreamWriter sw = new StreamWriter(file);

            sw.WriteLine(Prozentwerte[0]);
            sw.WriteLine(Prozentwerte[1]);
            sw.WriteLine(Prozentwerte[2]);
            sw.WriteLine(Prozentwerte[3]);
            sw.WriteLine(Prozentwerte[4]);
            sw.WriteLine(Language);

            sw.Close();
        }

    }
}
