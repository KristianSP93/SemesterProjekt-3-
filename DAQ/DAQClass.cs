using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQ
{
    public class DAQClass
    {
        public DAQClass()
        {

        }


        public void Blodtryk()
        {
            Random r = new Random();
            List<double> Liste = new List<double>();
            int counter = 0;

            while (!Console.KeyAvailable)
            {
                double random = r.Next(0, 10000);
                Liste.Add(random);
                //Console.WriteLine(Liste[counter]);
                counter++;
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
