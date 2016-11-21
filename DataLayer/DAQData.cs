using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using DAQ;
using DTO;

namespace DataLayer
{
    class DAQData
    {
        DAQClass CurrentDAQ = new DAQClass();
        Data BlodtrykDTO = new Data();

        public DAQData()
        {
            Thread thread = new Thread(CurrentDAQ.Blodtryk);
            thread.Start();

        }

        

    }
}
