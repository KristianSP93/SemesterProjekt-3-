using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;
using System.Threading;
using DTO;

namespace PresentationLayer
{
    public partial class HovedGUI : Form
    {
        private BL currentBL;
        private Data CurrentDTO;

        public HovedGUI(BL myBL)
        {
            currentBL = myBL;
            InitializeComponent();
        }

        private void HovedGUI_Load(object sender, EventArgs e)
        {
            // Tilføjer items til combobox
            comboBox1.Items.Add("Voksen");
            comboBox1.Items.Add("Barn");
            comboBox1.Items.Add("Spædbarn");
            comboBox1.Items.Add("Manuelt");
        }

        // Ignorer nedenstående
        private void HovedGUI_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Valg af combobox og udskrive textbox

            if (comboBox1.SelectedItem == "Voksen")
            {
                textBox1.Text = "100";
                textBox2.Text = "140";
                textBox3.Text = "70";
                textBox4.Text = "90";
            }

            //Blodtryksværdierne for barn og spædbarn fra linket:
            //http://ekstern.infonet.regionsyddanmark.dk/Files/dokument146824.htm

            //Barn def.: Fra 2 år til 18 år
            if (comboBox1.SelectedItem == "Barn")
            {
                textBox1.Text = "90";
                textBox2.Text = "135";
                textBox3.Text = "55";
                textBox4.Text = "85";
            }

            //Spædbarn def.: Fra nyfødt til 11 mdr
            if (comboBox1.SelectedItem == "Spædbarn")
            {
                textBox1.Text = "65";
                textBox2.Text = "100";
                textBox3.Text = "40";
                textBox4.Text = "65";
            }

            if (comboBox1.SelectedItem == "Manuelt")
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
        }
    }

}
