using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (radMass.Checked == true) 
            {
            

                double masa = int.Parse(textBox1.Text) / 2.2046;
                textBox2.Text = masa.ToString();    

            }
            if (radLength.Checked == true)
            {
   

                double duzina = int.Parse(textBox1.Text) * 0.3048;
                textBox2.Text = duzina.ToString(); 
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radMass_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "pounds";
            label2.Text = "kilograms";
        }

        private void radLength_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "feet";
            label2.Text = "meters";
        }
    }
    }

