using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheeseFactoryPlanning
{
    internal class CheeseProduction
    {
        private static Cheese fac = new Cheese();
        List<Cheese> Factory = new List<Cheese>();

        private static int iSize = 0;

        public void addToArray(String ID, String strName, String Date, String BBdate, String BatchNumber)
        {  Factory.Add(new Cheese(ID, strName, Date, BBdate, BatchNumber));
            iSize++;
        }
          
        public Cheese search(String ID)
        {
            Cheese output = new Cheese();
            for (int i = 0; i < iSize; i++)
            {
                Cheese Temp = Factory[i];
                if ((string)Temp["ID"]==ID) // if ((string)Factory[x]["ID"]==ID)
                {
                    output = Temp; 
                }
            }
            return output;
        }
    }

}
