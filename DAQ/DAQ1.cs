using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQ
{
    public class DAQ1
    {

        public List<Double> Blodtryk()
        {
            Random r = new Random();
            List<double> Liste = new List<double>();

            for (int i = 0; i < 500; i++)
            {
                double random = r.Next(0, 100);
                Liste.Add(random);
            }
            return Liste;
        }

    }
}
