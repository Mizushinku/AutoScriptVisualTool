using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Plot
{
    public partial class GetText_Form : AutoScriptVisualTool.BaseActionForm
    {
        public GetText_Form()
        {
            InitializeComponent();
        }

        public override string make_actstr()
        {
            return String.Format(" # GetText {0} {1}", name_tb.Text, index_tb.Text);
        }
    }
}
