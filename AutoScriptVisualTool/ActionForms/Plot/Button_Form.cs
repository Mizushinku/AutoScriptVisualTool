using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Plot
{
    public partial class Button_Form : AutoScriptVisualTool.BaseActionForm
    {
        /*
         * ShowButton   --> mod = 0
         * ChangeButton --> mod = 1
         */
        int mod;

        public Button_Form(int mod)
        {
            InitializeComponent();
            this.mod = mod;
        }

        public override string make_actstr()
        {
            string actstr = String.Empty;
            if(mod == 0)
            {
                actstr = String.Format(" # ShowButton {0} -> {1} {2},{3},{4},{5}",
                    name_tb.Text, trigger_name_tb.Text, pos_x_tb.Text, pos_y_tb.Text, width_tb.Text, height_tb.Text);
            }
            else if(mod == 1)
            {
                string trigger = (trigger_name_tb.Text == String.Empty) ?
                    "reserve" : trigger_name_tb.Text;
                string status = (pos_x_tb.Text == String.Empty || pos_y_tb.Text == String.Empty ||
                    width_tb.Text == String.Empty || height_tb.Text == String.Empty) ?
                    "reserve" : String.Format("{0},{1},{2},{3}", pos_x_tb.Text, pos_y_tb.Text, width_tb.Text, height_tb.Text);
                actstr = String.Format(" # ChangeButton {0} -> {1} {2}", name_tb.Text,  trigger, status);
            }
            return actstr;
        }
    }
}
