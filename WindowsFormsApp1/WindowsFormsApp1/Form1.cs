using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int _ticks;
        private int x = 0;
        private int y = 0;


        private Bitmap apple;
        private Bitmap head;
        private Bitmap dot;

        public Form1()
        {
            InitializeComponent();

            dot = new Bitmap("dot.png");
            head = new Bitmap("cathead.png");
            apple = new Bitmap("greenapple.png");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.Gray;
            label1.BackColor = Color.Gray;
            label2.BackColor = Color.Gray;
            label3.BackColor = Color.Gray;
            label4.BackColor = Color.Gray;
            label5.BackColor = Color.Gray;
            timer1.Enabled = false;


            


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;

        }  
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
