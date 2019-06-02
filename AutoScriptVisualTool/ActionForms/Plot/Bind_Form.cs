using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Plot
{
    public partial class Bind_Form : AutoScriptVisualTool.BaseActionForm
    {
        public Bind_Form()
        {
            InitializeComponent();
        }

        public override string make_actstr()
        {
            string actstr = String.Format(" # Bind {0} {1} {2}",
                type_cb.Text.Split(':')[0], keyname_tb.Text, obj_tb.Text);
            if (auto_cb.Checked) actstr += " +";
            return actstr;
        }
    }
}
