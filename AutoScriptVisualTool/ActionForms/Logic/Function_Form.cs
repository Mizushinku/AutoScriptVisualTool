using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Logic
{
    public partial class Function_Form : AutoScriptVisualTool.BaseActionForm
    {
        /*
         * Call     --> mod = 0
         * Execute  --> mod = 1
         */
        int mod;
        public Function_Form(int mod)
        {
            InitializeComponent();
            this.mod = mod;
            if(mod ==1)
            {
                label1.Text = "索引 :";
                name_tb.Size = new Size(75, 27);
                name_tb.TextAlign = HorizontalAlignment.Right;
            }
        }

        public override string make_actstr()
        {
            string actstr = String.Empty;
            if (mod == 0)
                actstr = String.Format(" # Call {0} {1}", name_tb.Text, param_tb.Text);
            else if (mod == 1)
                actstr = String.Format(" # Execute {0} {1}", name_tb.Text, param_tb.Text);
            return actstr;
        }
    }
}
