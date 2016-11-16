using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using DTO;

namespace BusinessLayer
{
    public class ControlBusinessLogic : BL
    {
        private Data abc;
        private DL currentDatalag;


        public ControlBusinessLogic(DL mydal)
        {
            var abc = new Data();
            this.currentDatalag = mydal;
        }


        public Data AtmofæriskTryk()
        {
            abc.AFTryk = currentDatalag.HentAFTryk();
            return abc;
        }


    }
}
