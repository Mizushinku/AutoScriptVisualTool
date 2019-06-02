using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Plot
{
    public partial class Input_Form : AutoScriptVisualTool.BaseActionForm
    {
        public Input_Form()
        {
            InitializeComponent();
        }

        public override string make_actstr()
        {
            string actstr = String.Format(" # ShowInput {0} {1},{2},{3},{4} {5}",
                name_tb.Text, x_tb.Text, y_tb.Text, width_tb.Text, height_tb.Text, lim_tb.Text);
            return actstr;
        }
    }
}
