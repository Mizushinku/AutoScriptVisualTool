using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Create
{
    public partial class Particle_Form : AutoScriptVisualTool.BaseActionForm
    {
        public Particle_Form()
        {
            InitializeComponent();
        }

        private void ref_cb_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = ((CheckBox)sender).Checked;
            label14.Visible = flag;
            ref_name_tb.Visible = flag;
            attach_cb.Enabled = flag;
            if (!flag) attach_cb.Checked = flag;
        }

        public override string make_actstr()
        {
            string actstr = String.Format(" # SpnParticle {0}", obj_name_cb.SelectedIndex);
            actstr += (ref_cb.Checked) ?
                " in " + ref_name_tb.Text : " at";
            actstr = String.Format("{0} {1},{2},{3} {4},{5},{6} {7}",
                actstr, pos_x_tb.Text, pos_y_tb.Text, pos_z_tb.Text, ang_x_tb.Text, ang_y_tb.Text, ang_z_tb.Text, time_tb.Text);
            if (attach_cb.Checked) actstr += " attach";

            return actstr;
        }
    }
}
