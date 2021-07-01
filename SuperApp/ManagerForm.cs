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
            this.trackBar1.Value = interval_now;
            this.label2.Text = this.trackBar1.Value.ToString();
          
        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("interval.config", this.trackBar1.Value.ToString());
        }
    }
}
