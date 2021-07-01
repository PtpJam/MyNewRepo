using System.IO;
using System.Windows.Forms;


namespace SuperApp
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }
        public ManagerForm(int interval_now) : this()
        {
            if (interval_now >= this.trackBar1.Minimum &&
               interval_now <= this.trackBar1.Maximum)
            {
                this.trackBar1.Value = interval_now;
                this.label2.Text = this.trackBar1.Value.ToString();
            }
          
        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("interval.config", this.trackBar1.Value.ToString());
        }

        private void trackBar1_ValueChanged(object sender, System.EventArgs e)
        {
            this.label2.Text = this.trackBar1.Value.ToString();
        }
    }
}
