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
        public bool main_script_flag { get; set; } = false;

        public Add_Form()
        {
            InitializeComponent();
        }


        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.which = 0;
            main_script_flag = main_script_cb.Checked;
            this.DialogResult = DialogResult.Cancel;
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            this.which = 1;
            main_script_flag = main_script_cb.Checked;
            this.DialogResult = DialogResult.OK;
        }

        private void trigger_btn_Click(object sender, EventArgs e)
        {
            this.which = 2;
            main_script_flag = main_script_cb.Checked;
            this.DialogResult = DialogResult.OK;
        }

        private void destroy_btn_Click(object sender, EventArgs e)
        {
            this.which = 3;
            main_script_flag = main_script_cb.Checked;
            this.DialogResult = DialogResult.OK;
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            this.which = 4;
            main_script_flag = main_script_cb.Checked;
            this.DialogResult = DialogResult.OK;
        }

        private void S1_btn_Click(object sender, EventArgs e)
        {
            this.which = 7;
            this.DialogResult = DialogResult.OK;
        }
        private void S2_btn_Click(object sender, EventArgs e)
        {
            this.which = 8;
            this.DialogResult = DialogResult.OK;
        }
        private void S3_btn_Click(object sender, EventArgs e)
        {
            this.which = 9;
            this.DialogResult = DialogResult.OK;
        }

        private void S4_btn_Click(object sender, EventArgs e)
        {
            this.which = 10;
            this.DialogResult = DialogResult.OK;
        }


    }
}
