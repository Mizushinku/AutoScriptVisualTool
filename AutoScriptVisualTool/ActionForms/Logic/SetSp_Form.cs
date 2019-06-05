using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Logic
{
    public partial class SetSp_Form : AutoScriptVisualTool.BaseActionForm
    {
        public SetSp_Form()
        {
            InitializeComponent();
        }

        private void sp_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = sp_cb.SelectedIndex;
            if (0 <= index && index <= 7)
            {
                label2.Visible = true;
                index_tb.Visible = true;
            }
            else
            {
                label2.Visible = false;
                index_tb.Visible = false;
            }
            index_tb.Text = "0";
        }

        public override string make_actstr()
        {
            return String.Format(" # SetSp {0} {1} {2}",
                index_tb.Text, sp_cb.Text.Split(' ')[0], value_tb.Text);
        }
    }
}
