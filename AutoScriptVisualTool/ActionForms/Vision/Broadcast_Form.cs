using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Vision
{
    public partial class Broadcast_Form : AutoScriptVisualTool.BaseActionForm
    {
        public Broadcast_Form()
        {
            InitializeComponent();
        }

        public override string make_actstr()
        {
            return String.Format(" # Broadcast {0}", msg_tb.Text);
        }
    }
}
