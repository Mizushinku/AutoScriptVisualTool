using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Enemy
{
    public partial class Monster_Form : AutoScriptVisualTool.BaseActionForm
    {
        public Monster_Form()
        {
            InitializeComponent();
        }

        public override string make_actstr()
        {
            return String.Format(" # GenMonster {0} {1},{2},{3} {4} {5} {6}",
                index_tb.Text, x_tb.Text, y_tb.Text, z_tb.Text, life_tb.Text, att_tb.Text, def_tb.Text);
        }
    }
}
