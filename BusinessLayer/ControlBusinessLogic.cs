using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using DTO;
using DataLayer;
using System.Threading;

namespace BusinessLayer
{
    public class ControlBusinessLogic : BL
    {
        private DL currentDal;

        Data currentDTO = new Data();


        public ControlBusinessLogic(DL myDL)
        {
            currentDal = myDL;
        }


        public Data CBIndlæsBlodtryk()
        {
            currentDTO.BlodtrykList = currentDal.CDIndlæsBlodtryk();
            return currentDTO;
        }




    }
}
