using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.LC
{
    public partial class LC_Form : AutoScriptVisualTool.BaseActionForm
    {
        /*
         * Log  --> mod = 1 
         * Cast --> mod = 2
         */
        int mod;
        public LC_Form(int mod)
        {
            InitializeComponent();
            this.mod = mod;
            if (mod == 1)
            {
                label1.Text = "Cast Variable :";
                msg_tb.Size = new Size(75, 27);
            }
        }

        public override string make_actstr()
        {
            string actstr = (mod == 0) ? " # Log " : " # Cast ";
            return actstr + msg_tb.Text;
        }
    }
}
