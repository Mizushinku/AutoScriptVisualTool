using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Plot
{
    public partial class Walk_Form : AutoScriptVisualTool.BaseActionForm
    {
        /*
         * Walk         --> mod = 0
         * WalkForward  --> mod = 1
         * WalkBackward --> mod = 2
         * WalkLeft     --> mod = 3
         * WalkRight    --> mod = 4
         * StopWalk     --> mod = 5
         */
        int mod;
        string[] actions = new string[]
        {
            "Walk", "WalkForward", "WalkBackward", "WalkLeft", "WalkRight", "StopWalk"
        };

        public Walk_Form(int mod)
        {
            InitializeComponent();
            this.mod = mod;
            if (mod > 0)
            {
                panel1.Visible = false;
                this.Controls.Add(new Label
                {
                    Font = new Font("新細明體", 10, FontStyle.Regular),
                    Text = "預設的方法",
                    Location = new Point(12, 35)
                });
            }
        }

        public override string make_actstr()
        {
            string actstr = String.Format(" # {0}", actions[mod]);

            if(mod == 0)
            {
                actstr = String.Format("{0} {1} {2} {3}", actstr, f_tb.Text, a_tb.Text, d_tb.Text);
                actstr += (p_cb.Checked) ? " pause" : " nopause";
                actstr += (fz_cb.Checked) ? " freeze" : " nofreeze";
            }

            return actstr;
        }
    }
}
