using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulacion2019
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 3000;
        }

        private void INICIO_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
