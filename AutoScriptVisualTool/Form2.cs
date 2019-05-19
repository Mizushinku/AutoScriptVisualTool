using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoScriptVisualTool
{
    public partial class Add_Form : Form
    {
        public int which { get; set; }

        public Add_Form()
        {
            InitializeComponent();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            this.which = 1;
            this.DialogResult = DialogResult.OK;
        }

        private void trigger_btn_Click(object sender, EventArgs e)
        {
            this.which = 2;
            this.DialogResult = DialogResult.OK;
        }

        private void destroy_btn_Click(object sender, EventArgs e)
        {
            this.which = 3;
            this.DialogResult = DialogResult.OK;
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            this.which = 4;
            this.DialogResult = DialogResult.OK;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.which = 0;
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
