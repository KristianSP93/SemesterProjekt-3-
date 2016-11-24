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

        public ControlDataLogic currentDL = new ControlDataLogic();
        public Data currentDTO = new Data();


        public ControlBusinessLogic(DL myDL)
        {
            currentDal = myDL;
        }





    }
}
