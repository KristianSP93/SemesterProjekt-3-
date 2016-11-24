using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAQ;

namespace DataLayer
{
    class DAQData
    {
        DAQ1 DataHenter;

        public List<double> DAQIndlæsTryk()
        {
            DataHenter = new DAQ1();
            return DataHenter.Blodtryk();
        }

    }
}
