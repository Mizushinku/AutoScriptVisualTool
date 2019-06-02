using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Plot
{
    public partial class Item_Form : AutoScriptVisualTool.BaseActionForm
    {
        /*
         * AddItem  --> mod = 0
         * AddEquip --> mod = 1
         */
        int mod;

        public Item_Form(int mod)
        {
            InitializeComponent();
            this.mod = mod;
            if (mod == 1) l1.Text = "裝備索引 :";
        }

        public override string make_actstr()
        {
            string actstr = String.Empty;
            if (mod == 0) actstr = String.Format(" # AddItem {0} {1}", index_tb.Text, amount_tb.Text);
            else if(mod == 1) actstr = String.Format(" # AddEquip {0} {1}", index_tb.Text, amount_tb.Text);
            actstr += (hint_cb.Checked) ? " on" : " off";

            return actstr;
        }
    }
}
