using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;


namespace DataLayer
{
    public class ControlDataLogic : DL
    {
        DAQData HentData;
        public List<double> CDIndlæsBlodtryk()
        {
            HentData = new DAQData();
            return HentData.DAQIndlæsTryk();
        }

    }
}