using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Logic
{
    public partial class GetSp_Form : AutoScriptVisualTool.BaseActionForm
    {
        public GetSp_Form()
        {
            InitializeComponent();
        }

        private void sp_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = sp_cb.SelectedIndex;
            if(0 <= index && index <= 22)
            {
                label3.Visible = true;
                index_tb.Visible = true;
            }
            else
            {
                label3.Visible = false;
                index_tb.Visible = false;
            }
        }

        public override string make_actstr()
        {
            string actstr = String.Format(" # GetSp {0} {1}", name_tb.Text, sp_cb.Text.Split(' ')[0]);
            if (0 <= sp_cb.SelectedIndex && sp_cb.SelectedIndex <= 22)
                actstr += " " + index_tb.Text;

            return actstr;
        }
    }
}
