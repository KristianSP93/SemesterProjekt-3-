using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;



namespace PresentationLayer
{
    public class ControlPresentationLayer : PL
    {
        private BL currentBL;

        public ControlPresentationLayer(BL myBL)
        {
            currentBL = myBL;
        }

        [STAThread] // skal være med
        public void startUpGUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.DoEvents();
            Application.Run(new HovedGUI(currentBL));
        }
    }
}