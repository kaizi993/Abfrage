using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotenDLL
{
    public class Class1
    {
        Settings settings;

        FirstStart firstStart;

        public Class1()
        {
            firstStart = new FirstStart();
            settings = new Settings();
        }

        public int noteBerechnen(int prozent)
        {
            int[] prozente = settings.getProzentwerte();

            if (prozent >= prozente[0])
            {
                return 1;
            }
            if (prozent < prozente[0] && prozent >= prozente[1])
            {
                return 2;
            }
            if (prozent < prozente[1] && prozent >= prozente[2])
            {
                return 3;
            }
            if (prozent < prozente[2] && prozent >= prozente[3])
            {
                return 4;
            }
            if (prozent < prozente[3] && prozent >= prozente[4])
            {
                return 5;
            }
            if (prozent < prozente[4])
            {
                return 6;
            }

            return 0;
        }

        public void prozentWertSpeichern(int p1, int p2, int p3, int p4, int p5)
        {
            settings.prozentwertSpeichern(p1, p2, p3, p4, p5);
        }

        public int[] getProzentwerte()
        {
            return settings.getProzentwerte();
        }
    }
}
