using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Plot
{
    public partial class Rename_Form : AutoScriptVisualTool.BaseActionForm
    {
        public Rename_Form()
        {
            InitializeComponent();
        }

        public override string make_actstr()
        {
            return String.Format(" # Rename {0} {1} {2}", type_cb.Text, order_tb.Text,name_tb.Text);
        }
    }
}
