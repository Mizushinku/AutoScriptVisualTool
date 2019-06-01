using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Create
{
    public partial class Virtual_Form : AutoScriptVisualTool.BaseActionForm
    {
        public Virtual_Form()
        {
            InitializeComponent();
        }

        private void ref_cb_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = ((CheckBox)sender).Checked;
            label7.Visible = flag;
            ref_name_tb.Visible = flag;
        }

        public override string make_actstr()
        {
            string actstr = String.Format(" # Virtual {0}", name_tb.Text);
            if(ref_cb.Checked)
            {
                actstr = String.Format("{0} in {1} {2},{3},{4}",
                    actstr, ref_name_tb.Text, x_tb.Text, y_tb.Text, z_tb.Text);
            }
            else
            {
                actstr = String.Format("{0} at {1},{2},{3}",
                    actstr, x_tb.Text, y_tb.Text, z_tb.Text);
            }

            actstr += (attach_cb.Checked) ? " attach" : " alone";
            if (clear_cb.Checked) actstr += " clear";

            return actstr;
        }
    }
}
