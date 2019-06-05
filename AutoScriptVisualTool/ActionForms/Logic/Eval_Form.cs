using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Logic
{
    public partial class Eval_Form : AutoScriptVisualTool.BaseActionForm
    {
        public Eval_Form()
        {
            InitializeComponent();
        }

        private void var_cb_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = var_cb.Checked;
            label3.Visible = flag;
            var_tb.Visible = flag;
        }

        public override string make_actstr()
        {
            string actstr = String.Format(" # Eval {0}", exp_tb.Text);
            if (var_cb.Checked) actstr += " to " + var_tb.Text;
            return actstr;
        }
    }
}
