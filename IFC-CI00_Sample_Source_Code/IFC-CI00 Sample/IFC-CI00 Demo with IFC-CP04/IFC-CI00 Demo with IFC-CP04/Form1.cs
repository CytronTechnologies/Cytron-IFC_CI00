using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        static ifc.ifc_ci ifc1 = new ifc.ifc_ci(3);
        ifc.ifc_cp cp1 = new ifc.ifc_cp(ifc1,1);

        byte flag;

        public Form1()
        {
            InitializeComponent();
        }           

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cp1.cp_sw(1) == true)label1.BackColor = Color.Salmon;
            else label1.BackColor = Color.Empty;
            if (cp1.cp_sw(2) == true)label2.BackColor = Color.Salmon;            
            else label2.BackColor = Color.Empty;
            if (cp1.cp_sw(3) == true)label3.BackColor = Color.Salmon; 
            else label3.BackColor = Color.Empty;
            if (cp1.cp_sw(4) == true) label4.BackColor = Color.Salmon;
            else  label4.BackColor = Color.Empty;            
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cp1.cp_clr();
            cp1.cp_str(textBox1.Text);
            cp1.cp_goto(1, 0);
            cp1.cp_str(textBox2.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                ifc1.ci_buzzer(1);
                button2.BackColor = Color.LightSkyBlue;
                flag = 1;
            }
            else
            {
                ifc1.ci_buzzer(0);
                button2.BackColor = Color.Empty;
                flag = 0;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            cp1.cp_blight(trackBar1.Value);
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox2.SelectAll();
        }



  
    }
}
