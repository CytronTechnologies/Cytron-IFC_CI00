using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        static ifc.ifc_ci ifc1 = new ifc.ifc_ci(3);

        byte flag = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ifc1.ci_led1(checkBox1.Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ifc1.ci_led2(checkBox2.Checked);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ifc1.ci_led3(checkBox3.Checked);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            ifc1.ci_led4(checkBox4.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (flag == 0)
            {
                ifc1.ci_buzzer(1);
                button1.BackColor = Color.LightSkyBlue;
                flag = 1;
            }
            else
            {
                ifc1.ci_buzzer(0);
                button1.BackColor = Color.Empty;
                flag = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte delay = 40;
            {
                ifc1.ci_smclr(1);
                Thread.Sleep(delay);                
                ifc1.ci_smclr(0);
            }
        }

     
    }
}
