using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SuperApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            colors = new Color[4];
            colors[0] = Color.Yellow;
            colors[1] = Color.Red;
            colors[2] = Color.Yellow;
            colors[3] = Color.Green;

            color_iter = -1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            changeColor();
        }
        private Color[] colors;
        private short color_iter;

        private void timer1_Tick(object sender, EventArgs e)
        {
            changeColor();
        }

        private void changeColor()
        {
            this.panel1.BackColor = colors[(++color_iter) % colors.Length];
            this.label1.Text = colors[(color_iter) % colors.Length].Name.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetIntervalFromFile();
        }
        void GetIntervalFromFile()
        {
            int interval = timer1.Interval;
            if (File.Exists("interval.config"))
            {
                if (int.TryParse(File.ReadAllText("interval.config"), out interval))
                {
                    interval *= 1000;
                }
            }
            timer1.Interval = interval;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (var form = new ManagerForm(timer1.Interval / 1000))
            {
                form.ShowDialog();
            }

            GetIntervalFromFile();
        }
    }
}