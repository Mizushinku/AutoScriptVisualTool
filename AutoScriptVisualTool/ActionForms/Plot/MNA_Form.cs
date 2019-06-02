using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Plot
{
    public partial class MNA_Form : AutoScriptVisualTool.BaseActionForm
    {
        /* MNA = Menu, NextOne, Alchemy
         * Menu     --> mod = 0
         * NextOne  --> mod = 1
         * Alchemy  --> mod = 2
         */
        int mod;

        public MNA_Form(int mod)
        {
            InitializeComponent();
            this.mod = mod;
            if (mod == 0) label1.Text = "打開主選單";
            else if (mod == 1) label1.Text = "更換成下一位成員";
            else if (mod == 2) label1.Text = "打開煉金模組";
        }

        public override string make_actstr()
        {
            string actstr = String.Empty;
            if (mod == 0) actstr = " # Menu";
            else if (mod == 1) actstr = " # NextOne";
            else if (mod == 2) actstr = " # Alchemy";

            return actstr;
        }
    }
}
