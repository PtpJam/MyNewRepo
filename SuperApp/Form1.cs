using System;
using System.Drawing;
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
            this.panel1.BackColor = colors[(++color_iter) % colors.Length];
            this.label1.Text = colors[(color_iter) % colors.Length].Name.ToString();
        }
        private Color[] colors;
        private short color_iter;
    }
}
